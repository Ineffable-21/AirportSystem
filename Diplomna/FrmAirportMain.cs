using Diplomna.DataAccess;
using Diplomna.Models;
using Diplomna.DBWork;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Drawing;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Xml.Linq;

namespace Diplomna
{
    public partial class FrmAirportMain : Form
    {
        private readonly DBDataAccess _dbContext;
        private readonly ClientWork _clientWork;
        private readonly FlightWork _flightWork;
        private readonly PlaneWork _planeWork;
        private readonly UserLoginLogWork _logWork;
        private readonly UserWork _userWork;
        private readonly TicketSoldWork _tickedSoldWork;
        private readonly PasswordHasher _passwordHasher;
        private int _selectedClientId;
        private int _selectedFlightId;
        private readonly TicketHelper ticketHelper;

        public FrmAirportMain(DBDataAccess dbContext, IConfiguration configuration)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _clientWork = new ClientWork(_dbContext);
            _flightWork = new FlightWork(_dbContext);
            _planeWork = new PlaneWork(_dbContext);
            _logWork = new UserLoginLogWork(_dbContext);
            _userWork = new UserWork(_dbContext);
            _tickedSoldWork = new TicketSoldWork(_dbContext);
            _passwordHasher = new PasswordHasher(configuration);
            ticketHelper = new TicketHelper(_tickedSoldWork, _planeWork);
        }

        private void LoadDataToGrids()
        {
            LoadClientsToClientsPage();
            LoadFlightsToFlightsPage();
            LoadClientsToSellTicketsPage();
            LoadFlightsToSellTicketsPage();
            LoadPlanes();
            LoadUsers();
            LoadSoldTickets();
            LoadLoginLog();
        }

        private void LoadClientsToClientsPage()
        {
            var clients = _clientWork.GetAllClients();
            DgvClients.DataSource = clients;
        }

        private void LoadFlightsToFlightsPage()
        {
            var flights = _flightWork.GetAllFlights();
            DgvFlights.DataSource = flights;
        }

        private void LoadClientsToSellTicketsPage()
        {
            var clients = _clientWork.GetAllClients();
            DgvSellToClients.DataSource = clients;
        }

        private void LoadFlightsToSellTicketsPage()
        {
            var flights = _flightWork.GetAllFlights();
            DgvFlightsToSell.DataSource = flights;
        }

        private void LoadPlanes()
        {
            var planes = _planeWork.GetAllPlanes();
            DgvPlanes.DataSource = planes;
        }

        private void LoadUsers()
        {
            var users = _userWork.GetAllUsers();
            DgvUsers.DataSource = users;
        }

        private void LoadSoldTickets()
        {
            var ticketsSold = _tickedSoldWork.GetAllTickets();
            DgvTicketsSold.DataSource = ticketsSold;
        }

        private void LoadLoginLog()
        {
            var loginLog = _logWork.GetAllLogs();
            DgvLoginLog.DataSource = loginLog;
        }

        private void FrmAirportMain_Load(object sender, EventArgs e)
        {
            FormatAndAdjust();
            LoadDataToGrids();
            LoadGendersIntoComboBox();
            LoadUserTypesIntoComboBox();
            LoadPlanesIntoComboBox();
            LoadFlightSituationIntoComboBox();
            MakePagesInvisibleForUsers();
        }

        private void MakePagesInvisibleForUsers()
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.UserName == CodeHelper.Username);

            if (user!.UserTypeId == "Пилот")
            {
                tabControl1.TabPages.Remove(TpBuyTickets);
                tabControl1.TabPages.Remove(TpClients);
                tabControl1.TabPages.Remove(TpUsers);
                tabControl1.TabPages.Remove(TpSoldTickets);
                tabControl1.TabPages.Remove(TpLog);
            }
            else if (user!.UserTypeId == "Продавач")
            {
                tabControl1.TabPages.Remove(TpUsers);
                tabControl1.TabPages.Remove(TpLog);
                tabControl1.TabPages.Remove(TpPlanes);
            }
        }

        private void FormatAndAdjust()
        {
            DgvSellToClientsFormatAndAdjust();
            DgvFlightsToSellFormatAndAdjust();
            DgvClientsFormatAndAdjust();
            DgvFlightsFormatAndAdjust();
            DgvPlanesFormatAndAdjust();
            DgvUsersFormatAndAdjust();
            DgvTicketsSoldFormatAndAdjust();
            DgvLoginLogFormatAndAdjust();
        }

        private void DgvSellToClientsFormatAndAdjust()
        {
            DgvSellToClients.AutoGenerateColumns = false;
            DgvSellToClients.ColumnCount = 6;
            DgvSellToClients.Columns[0].Visible = false;
            DgvSellToClients.Columns[0].DataPropertyName = "Id";
            DgvSellToClients.Columns[1].HeaderText = "Име";
            DgvSellToClients.Columns[1].DataPropertyName = "Name";
            DgvSellToClients.Columns[2].HeaderText = "Дата на раждане";
            DgvSellToClients.Columns[2].DataPropertyName = "DateOfBirth";
            DgvSellToClients.Columns[3].HeaderText = "Пол";
            DgvSellToClients.Columns[3].DataPropertyName = "SexId";
            DgvSellToClients.Columns[4].HeaderText = "Телефонен номер";
            DgvSellToClients.Columns[4].DataPropertyName = "PhoneNumber";
            DgvSellToClients.Columns[5].HeaderText = "Имейл адрес";
            DgvSellToClients.Columns[5].DataPropertyName = "EmailAddress";
            LoadClientsToSellTicketsPage();
        }

        private void DgvFlightsToSellFormatAndAdjust()
        {
            DgvFlightsToSell.AutoGenerateColumns = false;
            DgvFlightsToSell.ColumnCount = 11;
            DgvFlightsToSell.Columns[0].Visible = false;
            DgvFlightsToSell.Columns[0].DataPropertyName = "Id";
            DgvFlightsToSell.Columns[1].HeaderText = "От летище";
            DgvFlightsToSell.Columns[1].DataPropertyName = "FromAirport";
            DgvFlightsToSell.Columns[2].HeaderText = "До летище";
            DgvFlightsToSell.Columns[2].DataPropertyName = "ToAirport";
            DgvFlightsToSell.Columns[3].HeaderText = "Час на отлитане";
            DgvFlightsToSell.Columns[3].DataPropertyName = "TakeOffTime";
            DgvFlightsToSell.Columns[4].HeaderText = "Час на кацане";
            DgvFlightsToSell.Columns[4].DataPropertyName = "LandingTime";
            DgvFlightsToSell.Columns[5].HeaderText = "Свободни места";
            DgvFlightsToSell.Columns[5].DataPropertyName = "FreeSpaces";
            DgvFlightsToSell.Columns[6].HeaderText = "Самолетен №";
            DgvFlightsToSell.Columns[6].DataPropertyName = "PlaneId";
            DgvFlightsToSell.Columns[7].HeaderText = "Състояние на полета";
            DgvFlightsToSell.Columns[7].DataPropertyName = "FlightSituationId";
            DgvFlightsToSell.Columns[8].HeaderText = "Причина";
            DgvFlightsToSell.Columns[8].DataPropertyName = "Reason";
            DgvFlightsToSell.Columns[9].HeaderText = "Закъснение в минути";
            DgvFlightsToSell.Columns[9].DataPropertyName = "DelayMinutes";
            DgvFlightsToSell.Columns[10].HeaderText = "Да се връщат ли пари";
            DgvFlightsToSell.Columns[10].DataPropertyName = "ShouldReturnMoney";
        }

        private void DgvClientsFormatAndAdjust()
        {
            DgvClients.AutoGenerateColumns = false;
            DgvClients.ColumnCount = 6;
            DgvClients.Columns[0].Visible = false;
            DgvClients.Columns[0].DataPropertyName = "Id";
            DgvClients.Columns[1].HeaderText = "Име";
            DgvClients.Columns[1].DataPropertyName = "Name";
            DgvClients.Columns[2].HeaderText = "Дата на раждане";
            DgvClients.Columns[2].DataPropertyName = "DateOfBirth";
            DgvClients.Columns[3].HeaderText = "Пол";
            DgvClients.Columns[3].DataPropertyName = "SexId";
            DgvClients.Columns[4].HeaderText = "Телефонен номер";
            DgvClients.Columns[4].DataPropertyName = "PhoneNumber";
            DgvClients.Columns[5].HeaderText = "Имейл адрес";
            DgvClients.Columns[5].DataPropertyName = "EmailAddress";
            LoadClientsToClientsPage();
        }

        private void DgvFlightsFormatAndAdjust()
        {
            DgvFlights.AutoGenerateColumns = false;
            DgvFlights.ColumnCount = 11;
            DgvFlights.Columns[0].Visible = false;
            DgvFlights.Columns[0].DataPropertyName = "Id";
            DgvFlights.Columns[1].HeaderText = "От летище";
            DgvFlights.Columns[1].DataPropertyName = "FromAirport";
            DgvFlights.Columns[2].HeaderText = "До летище";
            DgvFlights.Columns[2].DataPropertyName = "ToAirport";
            DgvFlights.Columns[3].HeaderText = "Час на отлитане";
            DgvFlights.Columns[3].DataPropertyName = "TakeOffTime";
            DgvFlights.Columns[4].HeaderText = "Час на кацане";
            DgvFlights.Columns[4].DataPropertyName = "LandingTime";
            DgvFlights.Columns[5].HeaderText = "Свободни места";
            DgvFlights.Columns[5].DataPropertyName = "FreeSpaces";
            DgvFlights.Columns[6].HeaderText = "Самолетен №";
            DgvFlights.Columns[6].DataPropertyName = "PlaneId";
            DgvFlights.Columns[7].HeaderText = "Състояние на полета";
            DgvFlights.Columns[7].DataPropertyName = "FlightSituationId";
            DgvFlights.Columns[8].HeaderText = "Причина";
            DgvFlights.Columns[8].DataPropertyName = "Reason";
            DgvFlights.Columns[9].HeaderText = "Закъснение в минути";
            DgvFlights.Columns[9].DataPropertyName = "DelayMinutes";
            DgvFlights.Columns[10].HeaderText = "Да се връщат ли пари";
            DgvFlights.Columns[10].DataPropertyName = "ShouldReturnMoney";
            LoadFlightsToFlightsPage();
        }

        private void DgvPlanesFormatAndAdjust()
        {
            DgvPlanes.AutoGenerateColumns = false;
            DgvPlanes.ColumnCount = 12;
            DgvPlanes.Columns[0].HeaderText = "Самолетен №";
            DgvPlanes.Columns[0].DataPropertyName = "Id";
            DgvPlanes.Columns[1].HeaderText = "Общо места";
            DgvPlanes.Columns[1].DataPropertyName = "TotalSpaces";
            DgvPlanes.Columns[2].HeaderText = "Готов за полет";
            DgvPlanes.Columns[2].DataPropertyName = "CanFly";
            DgvPlanes.Columns[3].HeaderText = "Има икономични места";
            DgvPlanes.Columns[3].DataPropertyName = "HasEconomySeats";
            DgvPlanes.Columns[4].HeaderText = "Брой икономични билети";
            DgvPlanes.Columns[4].DataPropertyName = "EconomyTicketsCount";
            DgvPlanes.Columns[5].HeaderText = "Цена на иконимичен билет";
            DgvPlanes.Columns[5].DataPropertyName = "EconomyTicketsPrice";
            DgvPlanes.Columns[5].DefaultCellStyle.Format = "0.##";
            DgvPlanes.Columns[6].HeaderText = "Има бизнес места";
            DgvPlanes.Columns[6].DataPropertyName = "HasBusinessSeats";
            DgvPlanes.Columns[7].HeaderText = "Брой бизнес билети";
            DgvPlanes.Columns[7].DataPropertyName = "BusinessTicketsCount";
            DgvPlanes.Columns[8].HeaderText = "Цена на бизнес билет";
            DgvPlanes.Columns[8].DataPropertyName = "BusinessTicketsPrice";
            DgvPlanes.Columns[8].DefaultCellStyle.Format = "0.##";
            DgvPlanes.Columns[9].HeaderText = "Има 'Първа класа' места";
            DgvPlanes.Columns[9].DataPropertyName = "HasFirstClassSeats";
            DgvPlanes.Columns[10].HeaderText = "Брой 'Първа класа' билети";
            DgvPlanes.Columns[10].DataPropertyName = "FirstClassTicketsCount";
            DgvPlanes.Columns[11].HeaderText = "Цена на 'Първа класа' билет";
            DgvPlanes.Columns[11].DataPropertyName = "FirstClassTicketsPrice";
            DgvPlanes.Columns[11].DefaultCellStyle.Format = "0.##";
            LoadPlanes();
        }

        private void DgvUsersFormatAndAdjust()
        {
            DgvUsers.AutoGenerateColumns = false;
            DgvUsers.ColumnCount = 13;
            DgvUsers.Columns[0].Visible = false;
            DgvUsers.Columns[0].DataPropertyName = "id";
            DgvUsers.Columns[1].HeaderText = "Вид потребител";
            DgvUsers.Columns[1].DataPropertyName = "UserTypeId";
            DgvUsers.Columns[2].HeaderText = "Име";
            DgvUsers.Columns[2].DataPropertyName = "Name";
            DgvUsers.Columns[3].HeaderText = "Дата на раждане";
            DgvUsers.Columns[3].DataPropertyName = "DateOfBirth";
            DgvUsers.Columns[4].HeaderText = "Пол";
            DgvUsers.Columns[4].DataPropertyName = "SexId";
            DgvUsers.Columns[5].HeaderText = "Телефонен номер";
            DgvUsers.Columns[5].DataPropertyName = "PhoneNumber";
            DgvUsers.Columns[6].HeaderText = "Имейл адрес";
            DgvUsers.Columns[6].DataPropertyName = "EmailAddress";
            DgvUsers.Columns[7].Visible = false;
            DgvUsers.Columns[7].DataPropertyName = "UserName";
            DgvUsers.Columns[8].Visible = false;
            DgvUsers.Columns[8].DataPropertyName = "HashedUserPassword";
            DgvUsers.Columns[9].Visible = false;
            DgvUsers.Columns[9].DataPropertyName = "Salt";
            DgvUsers.Columns[10].HeaderText = "Последен вход";
            DgvUsers.Columns[10].DataPropertyName = "LastLogin";
            DgvUsers.Columns[11].Visible = false;
            DgvUsers.Columns[11].DataPropertyName = "FailedLoginCount";
            DgvUsers.Columns[12].HeaderText = "Заключен потребител";
            DgvUsers.Columns[12].DataPropertyName = "LockedUser";
            LoadUsers();
        }

        private void DgvTicketsSoldFormatAndAdjust()
        {
            DgvTicketsSold.AutoGenerateColumns = false;
            DgvTicketsSold.ColumnCount = 5;
            DgvTicketsSold.Columns[0].HeaderText = "Билетен №";
            DgvTicketsSold.Columns[0].DataPropertyName = "Id";
            DgvTicketsSold.Columns[1].HeaderText = "Клиентски №";
            DgvTicketsSold.Columns[1].DataPropertyName = "ClientId";
            DgvTicketsSold.Columns[2].HeaderText = "Полетен №";
            DgvTicketsSold.Columns[2].DataPropertyName = "FlightsId";
            DgvTicketsSold.Columns[3].HeaderText = "Крайна цена";
            DgvTicketsSold.Columns[3].DataPropertyName = "FinalPrice";
            DgvTicketsSold.Columns[3].DefaultCellStyle.Format = "0.##";
            DgvTicketsSold.Columns[4].HeaderText = "Дата на закупуване";
            DgvTicketsSold.Columns[4].DataPropertyName = "PurchaseDate";
            LoadSoldTickets();
        }

        private void DgvLoginLogFormatAndAdjust()
        {
            DgvLoginLog.AutoGenerateColumns = false;
            DgvLoginLog.ColumnCount = 3;
            DgvLoginLog.Columns[0].HeaderText = "Номер на вход в системата";
            DgvLoginLog.Columns[0].DataPropertyName = "Id";
            DgvLoginLog.Columns[1].HeaderText = "Номер на потребител";
            DgvLoginLog.Columns[1].DataPropertyName = "UserId";
            DgvLoginLog.Columns[2].HeaderText = "Дата на вход";
            DgvLoginLog.Columns[2].DataPropertyName = "LoginTime";
            LoadLoginLog();
        }

        private void BtnFilterClient_Click(object sender, EventArgs e)
        {
            string? name = ChBNameFilter.Checked && !string.IsNullOrWhiteSpace(TbName.Text) ? TbName.Text : null;
            DateTime? dateOfBirth = ChBDateOfBirthFilter.Checked ? DtpBirthday.Value.Date : (DateTime?)null;
            string? sexId = ChBGenderFilter.Checked && CbGender.SelectedItem != null ? CbGender.SelectedItem.ToString() : null;
            string? phoneNumber = ChBPhoneNumberFilter.Checked && !string.IsNullOrWhiteSpace(TbPhoneNumber.Text) ? TbPhoneNumber.Text : null;
            string? emailAddress = ChBEmailAddressFilter.Checked && !string.IsNullOrWhiteSpace(TbEmailAddress.Text) ? TbEmailAddress.Text : null;

            DgvSellToClients.DataSource = _clientWork.FilterClients(name, dateOfBirth, sexId, phoneNumber, emailAddress); ;
        }

        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            var newClient = new Client
            {
                Name = TbNameClient.Text,
                DateOfBirth = DtpBirthdayClient.Value.Date,
                SexId = CbGenderClient.SelectedItem?.ToString(),
                PhoneNumber = TbPhoneNumberClient.Text,
                EmailAddress = TbEmailAddressClient.Text
            };

            _clientWork.CreateClient(newClient);

            LoadClientsToClientsPage();
            LoadClientsToSellTicketsPage();
        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            if (DgvClients.CurrentRow == null) return;

            int selectedClientId = (int)DgvClients.CurrentRow.Cells[0].Value;

            var clientToUpdate = _dbContext.Clients.FirstOrDefault(c => c.Id == selectedClientId);
            if (clientToUpdate == null) return;

            clientToUpdate.Name = TbNameClient.Text;
            clientToUpdate.DateOfBirth = DtpBirthdayClient.Value;
            clientToUpdate.SexId = CbGenderClient.SelectedItem?.ToString();
            clientToUpdate.PhoneNumber = TbPhoneNumberClient.Text;
            clientToUpdate.EmailAddress = TbEmailAddressClient.Text;

            _clientWork.UpdateClient(clientToUpdate);

            LoadClientsToClientsPage();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            if (DgvClients.CurrentRow == null) return;

            int selectedClientId = (int)DgvClients.CurrentRow.Cells[0].Value;

            _clientWork.DeleteClient(selectedClientId);

            LoadClientsToClientsPage();
        }

        private void DgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvClients.CurrentRow != null)
            {
                TbNameClient.Text = DgvClients.CurrentRow.Cells[1].Value?.ToString();
                DtpBirthdayClient.Value = Convert.ToDateTime(DgvClients.CurrentRow.Cells[2].Value);
                CbGenderClient.SelectedItem = DgvClients.CurrentRow.Cells[3].Value?.ToString();
                TbPhoneNumberClient.Text = DgvClients.CurrentRow.Cells[4].Value?.ToString();
                TbEmailAddressClient.Text = DgvClients.CurrentRow.Cells[5].Value?.ToString();
            }
        }

        private void LoadGendersIntoComboBox()
        {
            var sexes = _dbContext.Sexes.Select(s => s.Gender).ToList();

            CbGenderClient.DataSource = sexes;
            CbGendersUsers.DataSource = sexes;
        }

        private void LoadUserTypesIntoComboBox()
        {
            var types = _dbContext.UsersTypes.Select(t => t.UserType).ToList();

            CbUserTypeUsers.DataSource = types;
        }

        private void LoadPlanesIntoComboBox()
        {
            var plane = _dbContext.Planes.Select(p => p.Id).ToList();

            CbPlaneId.DataSource = plane;
        }

        private void LoadFlightSituationIntoComboBox()
        {
            var flightSituation = _dbContext.FlightSituation.Select(fs => fs.FlightSituationName).ToList();

            CbFlightSituationId.DataSource = flightSituation;
        }

        private void BtnCreateFlight_Click(object sender, EventArgs e)
        {
            var newFlight = new Flight
            {
                FromAirport = TbFromAirport.Text,
                ToAirport = TbToAirport.Text,
                TakeOffTime = DtpTakeOffTime.Value.Date,
                LandingTime = DtpLandingTime.Value.Date,
                FreeSpaces = int.Parse(TbFreeSpaces.Text),
                PlaneId = int.Parse(CbPlaneId.Text),
                FlightSituationId = CbFlightSituationId.Text,
                Reason = string.IsNullOrWhiteSpace(TbReason.Text)
                    ? null
                    : (TbReason.Text),
                DelayMinutes = string.IsNullOrWhiteSpace(TbReason.Text)
                    ? null
                    : int.Parse(TbDelayMinutes.Text),
                ShouldReturnMoney = false
            };

            _flightWork.CreateFlight(newFlight);

            LoadFlightsToFlightsPage();
        }

        private void BtnCreatePlane_Click(object sender, EventArgs e)
        {
            var newPlane = new Models.Plane
            {
                TotalSpaces = int.Parse(TbTotalSpaces.Text),
                CanFly = ChBCanFly.Checked,
                HasEconomySeats = ChBHasEconomySeats.Checked,
                EconomyTicketsCount = string.IsNullOrWhiteSpace(TbEconomyTicketsCount.Text)
                    ? null
                    : int.Parse(TbEconomyTicketsCount.Text),
                EconomyTicketsPrice = string.IsNullOrWhiteSpace(TbEconomyTicketsPrice.Text)
                    ? null
                    : int.Parse(TbEconomyTicketsPrice.Text),
                HasBusinessSeats = ChBHasBusinessSeats.Checked,
                BusinessTicketsCount = string.IsNullOrWhiteSpace(TbBusinessTicketsCount.Text)
                    ? null
                    : int.Parse(TbBusinessTicketsCount.Text),
                BusinessTicketsPrice = string.IsNullOrWhiteSpace(TbBusinessTicketsPrice.Text)
                    ? null
                    : int.Parse(TbBusinessTicketsPrice.Text),
                HasFirstClassSeats = ChBHasFirstClassSeats.Checked,
                FirstClassTicketsCount = string.IsNullOrWhiteSpace(TbFirstClassTicketsCount.Text)
                    ? null
                    : int.Parse(TbFirstClassTicketsCount.Text),
                FirstClassTicketsPrice = string.IsNullOrWhiteSpace(TbFirstClassTicketsPrice.Text)
                    ? null
                    : int.Parse(TbFirstClassTicketsPrice.Text)
            };

            _planeWork.CreatePlane(newPlane);

            LoadPlanes();
        }

        private void BtnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (DgvFlights.CurrentRow == null) return;

            int selectedFlightId = (int)DgvFlights.CurrentRow.Cells[0].Value;

            var flightToUpdate = _dbContext.Flights.FirstOrDefault(c => c.Id == selectedFlightId);
            if (flightToUpdate == null) return;

            flightToUpdate.FromAirport = TbFromAirport.Text;
            flightToUpdate.ToAirport = TbToAirport.Text;
            flightToUpdate.TakeOffTime = DtpTakeOffTime.Value.Date;
            flightToUpdate.LandingTime = DtpLandingTime.Value.Date;
            flightToUpdate.FreeSpaces = int.Parse(TbFreeSpaces.Text);
            flightToUpdate.PlaneId = int.Parse(CbPlaneId.Text);
            flightToUpdate.FlightSituationId = CbFlightSituationId.Text;
            flightToUpdate.Reason = TbReason.Text;
            if (TbDelayMinutes.Text != "")
                flightToUpdate.DelayMinutes = int.Parse(TbDelayMinutes.Text);

            _flightWork.UpdateFlight(flightToUpdate);

            LoadClientsToClientsPage();
        }

        private void BtnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (DgvFlights.CurrentRow == null) return;

            int selectedFlightId = (int)DgvFlights.CurrentRow.Cells[0].Value;

            _flightWork.DeleteFlight(selectedFlightId);

            LoadFlightsToFlightsPage();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            string salt = PasswordHasher.GenerateSalt();

            string hashedPassword = _passwordHasher.HashPassword(TbPasswordUser.Text, salt);

            var newUser = new User
            {
                UserTypeId = CbUserTypeUsers.Text,
                Name = TbNameUsers.Text,
                DateOfBirth = DtpBirthdayUsers.Value.Date,
                SexId = CbGendersUsers.Text,
                PhoneNumber = TbPhoneNumberUsers.Text,
                EmailAddress = TbEmailAddressUsers.Text,
                UserName = TbUsernameUsers.Text,
                HashedUserPassword = hashedPassword,
                Salt = salt,
                LockedUser = ChBLockedUser.Checked
            };

            _userWork.CreateUsers(newUser);

            LoadUsers();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            string salt = PasswordHasher.GenerateSalt();

            string hashedPassword = _passwordHasher.HashPassword(TbPasswordUser.Text, salt);

            var newUser = new User
            {
                UserTypeId = CbUserTypeUsers.Text,
                Name = TbNameUsers.Text,
                DateOfBirth = DtpBirthdayUsers.Value.Date,
                SexId = CbGendersUsers.Text,
                PhoneNumber = TbPhoneNumberUsers.Text,
                EmailAddress = TbEmailAddressUsers.Text,
                UserName = TbUsernameUsers.Text,
                HashedUserPassword = hashedPassword,
                Salt = salt,
                LockedUser = ChBLockedUser.Checked
            };

            _userWork.UpdateUsers(newUser);

            LoadUsers();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (DgvUsers.CurrentRow == null) return;

            int selectedUserId = (int)DgvUsers.CurrentRow.Cells[0].Value;

            _userWork.DeleteUsers(selectedUserId);

            LoadUsers();
        }

        private void BtnBuyTickets_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ticketHelper.ValidateTicketInput(_selectedClientId, _selectedFlightId, CbTicketClass.SelectedItem?.ToString()!, TbTicketsNum.Text, out int ticketsNum, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string? ticketClass = CbTicketClass.SelectedItem?.ToString();
                if (!ticketHelper.CheckAvailableTickets(_selectedFlightId, ticketClass!, ticketsNum, out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal? basePrice = ticketHelper.GetBasePrice(_selectedFlightId, ticketClass!);
                if (basePrice == null)
                {
                    MessageBox.Show("Избрана е невалидна класа на билет.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal? finalPrice = ticketHelper.CalculateFinalPrice(basePrice, ticketsNum);
                if (!finalPrice.HasValue)
                {
                    MessageBox.Show("Невалидна крайна цена.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < ticketsNum; i++)
                {
                    var newTicket = new TicketSold
                    {
                        ClientId = _selectedClientId,
                        FlightsId = _selectedFlightId,
                        FinalPrice = basePrice.Value,
                        PurchaseDate = DateTime.Now
                    };

                    _tickedSoldWork.CreateTickets(newTicket);
                }

                ticketHelper.UpdateTicketCounts(_selectedFlightId, ticketClass!, ticketsNum, ticketSold: true);

                MessageBox.Show("Успешно закупуване на билети!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TbTicketsNum.Clear();
                CbTicketClass.SelectedIndex = -1;
                LblTicketsPrice.Text = "Цена: ";
                LoadSoldTickets();
                LoadFlightsToSellTicketsPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvSellToClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedClientId = Convert.ToInt32(DgvSellToClients.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void DgvFlightsToSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedFlightId = Convert.ToInt32(DgvFlightsToSell.Rows[e.RowIndex].Cells[0].Value);
                UpdateTicketPrice();
            }
        }

        private void UpdateTicketPrice()
        {
            try
            {
                if (!int.TryParse(TbTicketsNum.Text, out int ticketsNum) || ticketsNum <= 0)
                {
                    LblTicketsPrice.Text = "Цена: ";
                    return;
                }

                string? ticketClass = CbTicketClass.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(ticketClass) || _selectedFlightId == 0)
                {
                    LblTicketsPrice.Text = "Цена: ";
                    return;
                }

                decimal? basePrice = ticketHelper.GetBasePrice(_selectedFlightId, ticketClass);

                if (basePrice == null)
                {
                    LblTicketsPrice.Text = "Цена: ";
                    return;
                }

                decimal? finalPrice = ticketHelper.CalculateFinalPrice(basePrice, ticketsNum);

                LblTicketsPrice.Text = finalPrice.HasValue ? finalPrice.Value.ToString("F2") : "0";
            }
            catch (Exception ex)
            {
                LblTicketsPrice.Text = "Цена: ";
                MessageBox.Show($"Грешка при пресмятане на цената: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbTicketsNum_TextChanged(object sender, EventArgs e)
        {
            UpdateTicketPrice();
        }

        private void CbTicketClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTicketPrice();
        }

        private void BtnDeleteTicket_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletePlane_Click(object sender, EventArgs e)
        {
            if (DgvPlanes.CurrentRow == null) return;

            int selectedPlaneId = (int)DgvPlanes.CurrentRow.Cells[0].Value;

            _planeWork.DeletePlane(selectedPlaneId);

            LoadPlanes();
        }

        private void BtnUpdatePlane_Click(object sender, EventArgs e)
        {
            if (DgvPlanes.CurrentRow == null) return;

            int selectedPlaneId = (int)DgvPlanes.CurrentRow.Cells[0].Value;

            var planeToUpdate = _dbContext.Planes.FirstOrDefault(c => c.Id == selectedPlaneId);
            if (planeToUpdate == null) return;

            planeToUpdate.TotalSpaces = int.Parse(TbTotalSpaces.Text);
            planeToUpdate.CanFly = ChBCanFly.Checked;
            planeToUpdate.HasEconomySeats = ChBHasEconomySeats.Checked;
            planeToUpdate.EconomyTicketsCount = string.IsNullOrWhiteSpace(TbEconomyTicketsCount.Text)
                ? null
                : int.Parse(TbEconomyTicketsCount.Text);
            planeToUpdate.EconomyTicketsPrice = string.IsNullOrWhiteSpace(TbEconomyTicketsPrice.Text)
                ? null
                : int.Parse(TbEconomyTicketsPrice.Text);
            planeToUpdate.HasBusinessSeats = ChBHasBusinessSeats.Checked;
            planeToUpdate.BusinessTicketsCount = string.IsNullOrWhiteSpace(TbBusinessTicketsCount.Text)
                ? null
                : int.Parse(TbBusinessTicketsCount.Text);
            planeToUpdate.BusinessTicketsPrice = string.IsNullOrWhiteSpace(TbBusinessTicketsPrice.Text)
                ? null
                : int.Parse(TbBusinessTicketsPrice.Text);
            planeToUpdate.HasFirstClassSeats = ChBHasFirstClassSeats.Checked;
            planeToUpdate.FirstClassTicketsCount = string.IsNullOrWhiteSpace(TbFirstClassTicketsCount.Text)
                ? null
                : int.Parse(TbFirstClassTicketsCount.Text);
            planeToUpdate.FirstClassTicketsPrice = string.IsNullOrWhiteSpace(TbFirstClassTicketsPrice.Text)
                ? null
                : int.Parse(TbFirstClassTicketsPrice.Text);

            _planeWork.UpdatePlane(planeToUpdate);

            LoadPlanes();
        }
    }
}
