using Diplomna.DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplomna.DBWork;
using Diplomna.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace Diplomna
{
    public partial class FrmLogin : Form
    {
        private readonly DBDataAccess _dbContext;
        private readonly IConfiguration _configuration;
        private readonly PasswordHasher _passwordHasher;
        private readonly UserLoginLogWork _logWork;
        private readonly UserWork _userWork;
        public FrmLogin(DBDataAccess dbContext, IConfiguration configuration)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _passwordHasher = new PasswordHasher(configuration);
            _logWork = new UserLoginLogWork(_dbContext);
            _userWork = new UserWork(_dbContext);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TbUserName.Text;
            string password = TbPassword.Text;

            if (AuthenticateUser(username, password))
            {
                if (UserIsAdmin(username))
                {
                    FrmRegister registerForm = new(_dbContext, _configuration);
                    registerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Профилът няма права на Админ!");
                }
            }
            else
            {
                MessageBox.Show("Невалидно име или парола!");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TbUserName.Text;
            string password = TbPassword.Text;

            if (AuthenticateUser(username, password))
            {
                CodeHelper.Username = username;

                var user = _dbContext.Users.SingleOrDefault(u => u.UserName == username);
                AddLoginTimeToUser(user!.Id);
                AddUserLoginLog(user!.Id);

                MessageBox.Show("Успешен вход!");
                DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Невалидно име или парола!");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {   
                var user = _dbContext.Users.SingleOrDefault(u => u.UserName == username);
                if (user == null)
                {
                    return false;
                }

                return _passwordHasher.VerifyPassword(password, user.Salt!, user.HashedUserPassword!);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.Message}");
                return false;
            }
        }

        private bool UserIsAdmin(string username)
        {
            try
            {
                var user = _dbContext.Users.SingleOrDefault(u => u.UserName == username);
                if (user == null)
                {
                    return false;
                }

                if (user.UserTypeId == "Админ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.Message}");
                return false;
            }
        }

        private void AddUserLoginLog(int? userId)
        {
            var newLog = new UserLoginLog
            {
                UserId = userId,
                LoginTime = DateTime.Now
            };

            _logWork.CreateLogs(newLog);
        }

        private void AddLoginTimeToUser(int? userId)
        {
            _userWork.AddLastLoginToUsers(userId);
        }
    }
}
