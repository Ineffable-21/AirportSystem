using Diplomna.DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplomna.Models;

namespace Diplomna
{
    public partial class FrmRegister : Form
    {
        private readonly DBDataAccess _dbContext;
        private readonly PasswordHasher _passwordHasher;
        public FrmRegister(DBDataAccess dbContext, IConfiguration configuration)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

            _passwordHasher = new PasswordHasher(configuration);
        }

        private void LoadGendersIntoComboBox()
        {
            var sexes = _dbContext.Sexes.Select(s => s.Gender).ToList();

            CbGenders.DataSource = sexes;
        }

        private void LoadUserTypesIntoComboBox()
        {
            var usersTypes = _dbContext.UsersTypes.Select(uT => uT.UserType).ToList();

            CbUsersType.DataSource = usersTypes;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            LoadGendersIntoComboBox();
            LoadUserTypesIntoComboBox();
        }

        private void RegisterUser()
        {
            string salt = PasswordHasher.GenerateSalt();

            string hashedPassword = _passwordHasher.HashPassword(TbPassword.Text, salt);

            var newUser = new User
            {
                UserTypeId = CbUsersType.Text,
                Name = TbName.Text,
                DateOfBirth = DtpBirthday.Value.Date,
                SexId = CbGenders.Text,
                PhoneNumber = TbPhoneNumber.Text,
                EmailAddress = TbEmailAddress.Text,
                UserName = TbUserName.Text,
                HashedUserPassword = hashedPassword,
                Salt = salt,
                LockedUser = false
            };

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            MessageBox.Show("User registered successfully!");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                MessageBox.Show($"Inner exception: {ex.InnerException?.Message}");
            }
        }
    }
}
