namespace Diplomna
{
    partial class FrmAirportMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TpFlights = new TabPage();
            BtnDeleteFlight = new Button();
            BtnUpdateFlight = new Button();
            BtnCreateFlight = new Button();
            CbFlightSituationId = new ComboBox();
            CbPlaneId = new ComboBox();
            DtpLandingTime = new DateTimePicker();
            DtpTakeOffTime = new DateTimePicker();
            TbDelayMinutes = new TextBox();
            TbReason = new TextBox();
            TbFreeSpaces = new TextBox();
            TbToAirport = new TextBox();
            TbFromAirport = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            DgvFlights = new DataGridView();
            tabControl1 = new TabControl();
            TpBuyTickets = new TabPage();
            ChBEmailAddressFilter = new CheckBox();
            ChBPhoneNumberFilter = new CheckBox();
            ChBGenderFilter = new CheckBox();
            ChBDateOfBirthFilter = new CheckBox();
            ChBNameFilter = new CheckBox();
            LblTicketsPrice = new Label();
            BtnBuyTickets = new Button();
            CbTicketClass = new ComboBox();
            TbTicketsNum = new TextBox();
            label7 = new Label();
            label6 = new Label();
            BtnFilterClient = new Button();
            CbGender = new ComboBox();
            DtpBirthday = new DateTimePicker();
            TbEmailAddress = new TextBox();
            TbPhoneNumber = new TextBox();
            TbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DgvFlightsToSell = new DataGridView();
            DgvSellToClients = new DataGridView();
            TpClients = new TabPage();
            BtnDeleteClient = new Button();
            BtnUpdateClient = new Button();
            BtnCreateClient = new Button();
            DtpBirthdayClient = new DateTimePicker();
            TbEmailAddressClient = new TextBox();
            TbPhoneNumberClient = new TextBox();
            TbNameClient = new TextBox();
            CbGenderClient = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            DgvClients = new DataGridView();
            TpPlanes = new TabPage();
            BtnDeletePlane = new Button();
            BtnUpdatePlane = new Button();
            BtnCreatePlane = new Button();
            ChBHasFirstClassSeats = new CheckBox();
            ChBHasBusinessSeats = new CheckBox();
            ChBHasEconomySeats = new CheckBox();
            ChBCanFly = new CheckBox();
            TbFirstClassTicketsPrice = new TextBox();
            TbBusinessTicketsPrice = new TextBox();
            TbBusinessTicketsCount = new TextBox();
            TbEconomyTicketsPrice = new TextBox();
            TbFirstClassTicketsCount = new TextBox();
            TbEconomyTicketsCount = new TextBox();
            TbTotalSpaces = new TextBox();
            label35 = new Label();
            label34 = new Label();
            label32 = new Label();
            label31 = new Label();
            label29 = new Label();
            label28 = new Label();
            label25 = new Label();
            DgvPlanes = new DataGridView();
            TpUsers = new TabPage();
            BtnCreateUser = new Button();
            BtnUpdateUser = new Button();
            BtnDeleteUser = new Button();
            DtpBirthdayUsers = new DateTimePicker();
            TbPasswordUser = new TextBox();
            TbUsernameUsers = new TextBox();
            TbEmailAddressUsers = new TextBox();
            TbPhoneNumberUsers = new TextBox();
            TbNameUsers = new TextBox();
            CbGendersUsers = new ComboBox();
            CbUserTypeUsers = new ComboBox();
            ChBLockedUser = new CheckBox();
            label37 = new Label();
            label36 = new Label();
            label33 = new Label();
            label30 = new Label();
            label27 = new Label();
            label26 = new Label();
            label24 = new Label();
            label23 = new Label();
            DgvUsers = new DataGridView();
            TpSoldTickets = new TabPage();
            DgvTicketsSold = new DataGridView();
            TpLog = new TabPage();
            DgvLoginLog = new DataGridView();
            TpFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFlights).BeginInit();
            tabControl1.SuspendLayout();
            TpBuyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFlightsToSell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSellToClients).BeginInit();
            TpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvClients).BeginInit();
            TpPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPlanes).BeginInit();
            TpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsers).BeginInit();
            TpSoldTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTicketsSold).BeginInit();
            TpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLoginLog).BeginInit();
            SuspendLayout();
            // 
            // TpFlights
            // 
            TpFlights.Controls.Add(BtnDeleteFlight);
            TpFlights.Controls.Add(BtnUpdateFlight);
            TpFlights.Controls.Add(BtnCreateFlight);
            TpFlights.Controls.Add(CbFlightSituationId);
            TpFlights.Controls.Add(CbPlaneId);
            TpFlights.Controls.Add(DtpLandingTime);
            TpFlights.Controls.Add(DtpTakeOffTime);
            TpFlights.Controls.Add(TbDelayMinutes);
            TpFlights.Controls.Add(TbReason);
            TpFlights.Controls.Add(TbFreeSpaces);
            TpFlights.Controls.Add(TbToAirport);
            TpFlights.Controls.Add(TbFromAirport);
            TpFlights.Controls.Add(label22);
            TpFlights.Controls.Add(label21);
            TpFlights.Controls.Add(label20);
            TpFlights.Controls.Add(label19);
            TpFlights.Controls.Add(label18);
            TpFlights.Controls.Add(label17);
            TpFlights.Controls.Add(label16);
            TpFlights.Controls.Add(label15);
            TpFlights.Controls.Add(label14);
            TpFlights.Controls.Add(DgvFlights);
            TpFlights.Location = new Point(4, 29);
            TpFlights.Name = "TpFlights";
            TpFlights.Size = new Size(1146, 641);
            TpFlights.TabIndex = 2;
            TpFlights.Text = "Полети";
            TpFlights.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteFlight
            // 
            BtnDeleteFlight.Location = new Point(1021, 101);
            BtnDeleteFlight.Name = "BtnDeleteFlight";
            BtnDeleteFlight.Size = new Size(122, 41);
            BtnDeleteFlight.TabIndex = 22;
            BtnDeleteFlight.Text = "Изтрий";
            BtnDeleteFlight.UseVisualStyleBackColor = true;
            BtnDeleteFlight.Click += BtnDeleteFlight_Click;
            // 
            // BtnUpdateFlight
            // 
            BtnUpdateFlight.Location = new Point(1021, 54);
            BtnUpdateFlight.Name = "BtnUpdateFlight";
            BtnUpdateFlight.Size = new Size(122, 41);
            BtnUpdateFlight.TabIndex = 21;
            BtnUpdateFlight.Text = "Промени";
            BtnUpdateFlight.UseVisualStyleBackColor = true;
            BtnUpdateFlight.Click += BtnUpdateFlight_Click;
            // 
            // BtnCreateFlight
            // 
            BtnCreateFlight.Location = new Point(1021, 6);
            BtnCreateFlight.Name = "BtnCreateFlight";
            BtnCreateFlight.Size = new Size(122, 41);
            BtnCreateFlight.TabIndex = 20;
            BtnCreateFlight.Text = "Създай";
            BtnCreateFlight.UseVisualStyleBackColor = true;
            BtnCreateFlight.Click += BtnCreateFlight_Click;
            // 
            // CbFlightSituationId
            // 
            CbFlightSituationId.FormattingEnabled = true;
            CbFlightSituationId.Location = new Point(805, 319);
            CbFlightSituationId.Name = "CbFlightSituationId";
            CbFlightSituationId.Size = new Size(182, 28);
            CbFlightSituationId.TabIndex = 19;
            // 
            // CbPlaneId
            // 
            CbPlaneId.FormattingEnabled = true;
            CbPlaneId.Location = new Point(805, 269);
            CbPlaneId.Name = "CbPlaneId";
            CbPlaneId.Size = new Size(182, 28);
            CbPlaneId.TabIndex = 18;
            // 
            // DtpLandingTime
            // 
            DtpLandingTime.CustomFormat = "yyyy-MM-dd HH:mm";
            DtpLandingTime.Format = DateTimePickerFormat.Custom;
            DtpLandingTime.Location = new Point(805, 171);
            DtpLandingTime.Name = "DtpLandingTime";
            DtpLandingTime.Size = new Size(182, 27);
            DtpLandingTime.TabIndex = 17;
            // 
            // DtpTakeOffTime
            // 
            DtpTakeOffTime.CustomFormat = "yyyy-MM-dd HH:mm";
            DtpTakeOffTime.Format = DateTimePickerFormat.Custom;
            DtpTakeOffTime.Location = new Point(805, 122);
            DtpTakeOffTime.Name = "DtpTakeOffTime";
            DtpTakeOffTime.Size = new Size(182, 27);
            DtpTakeOffTime.TabIndex = 16;
            // 
            // TbDelayMinutes
            // 
            TbDelayMinutes.Location = new Point(805, 418);
            TbDelayMinutes.Name = "TbDelayMinutes";
            TbDelayMinutes.Size = new Size(182, 27);
            TbDelayMinutes.TabIndex = 15;
            // 
            // TbReason
            // 
            TbReason.Location = new Point(805, 369);
            TbReason.Name = "TbReason";
            TbReason.Size = new Size(182, 27);
            TbReason.TabIndex = 14;
            // 
            // TbFreeSpaces
            // 
            TbFreeSpaces.Location = new Point(805, 220);
            TbFreeSpaces.Name = "TbFreeSpaces";
            TbFreeSpaces.Size = new Size(182, 27);
            TbFreeSpaces.TabIndex = 13;
            // 
            // TbToAirport
            // 
            TbToAirport.Location = new Point(805, 73);
            TbToAirport.Name = "TbToAirport";
            TbToAirport.Size = new Size(182, 27);
            TbToAirport.TabIndex = 12;
            // 
            // TbFromAirport
            // 
            TbFromAirport.Location = new Point(805, 24);
            TbFromAirport.Name = "TbFromAirport";
            TbFromAirport.Size = new Size(182, 27);
            TbFromAirport.TabIndex = 11;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(805, 397);
            label22.Name = "label22";
            label22.Size = new Size(158, 20);
            label22.TabIndex = 9;
            label22.Text = "Закъснение в минути";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(805, 348);
            label21.Name = "label21";
            label21.Size = new Size(72, 20);
            label21.TabIndex = 8;
            label21.Text = "Причина";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(805, 298);
            label20.Name = "label20";
            label20.Size = new Size(156, 20);
            label20.TabIndex = 7;
            label20.Text = "Състояние на полета";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(805, 248);
            label19.Name = "label19";
            label19.Size = new Size(135, 20);
            label19.TabIndex = 6;
            label19.Text = "Самолетен номер";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(805, 199);
            label18.Name = "label18";
            label18.Size = new Size(123, 20);
            label18.TabIndex = 5;
            label18.Text = "Свободни места";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(805, 150);
            label17.Name = "label17";
            label17.Size = new Size(108, 20);
            label17.TabIndex = 4;
            label17.Text = "Час на кацане";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(805, 101);
            label16.Name = "label16";
            label16.Size = new Size(122, 20);
            label16.TabIndex = 3;
            label16.Text = "Час на отлитане";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(805, 52);
            label15.Name = "label15";
            label15.Size = new Size(83, 20);
            label15.TabIndex = 2;
            label15.Text = "До летище";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(805, 3);
            label14.Name = "label14";
            label14.Size = new Size(81, 20);
            label14.TabIndex = 1;
            label14.Text = "От летище";
            // 
            // DgvFlights
            // 
            DgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFlights.Location = new Point(0, 0);
            DgvFlights.Name = "DgvFlights";
            DgvFlights.RowHeadersWidth = 51;
            DgvFlights.Size = new Size(799, 641);
            DgvFlights.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(TpBuyTickets);
            tabControl1.Controls.Add(TpClients);
            tabControl1.Controls.Add(TpFlights);
            tabControl1.Controls.Add(TpPlanes);
            tabControl1.Controls.Add(TpUsers);
            tabControl1.Controls.Add(TpSoldTickets);
            tabControl1.Controls.Add(TpLog);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1154, 674);
            tabControl1.TabIndex = 0;
            // 
            // TpBuyTickets
            // 
            TpBuyTickets.Controls.Add(ChBEmailAddressFilter);
            TpBuyTickets.Controls.Add(ChBPhoneNumberFilter);
            TpBuyTickets.Controls.Add(ChBGenderFilter);
            TpBuyTickets.Controls.Add(ChBDateOfBirthFilter);
            TpBuyTickets.Controls.Add(ChBNameFilter);
            TpBuyTickets.Controls.Add(LblTicketsPrice);
            TpBuyTickets.Controls.Add(BtnBuyTickets);
            TpBuyTickets.Controls.Add(CbTicketClass);
            TpBuyTickets.Controls.Add(TbTicketsNum);
            TpBuyTickets.Controls.Add(label7);
            TpBuyTickets.Controls.Add(label6);
            TpBuyTickets.Controls.Add(BtnFilterClient);
            TpBuyTickets.Controls.Add(CbGender);
            TpBuyTickets.Controls.Add(DtpBirthday);
            TpBuyTickets.Controls.Add(TbEmailAddress);
            TpBuyTickets.Controls.Add(TbPhoneNumber);
            TpBuyTickets.Controls.Add(TbName);
            TpBuyTickets.Controls.Add(label1);
            TpBuyTickets.Controls.Add(label2);
            TpBuyTickets.Controls.Add(label3);
            TpBuyTickets.Controls.Add(label4);
            TpBuyTickets.Controls.Add(label5);
            TpBuyTickets.Controls.Add(DgvFlightsToSell);
            TpBuyTickets.Controls.Add(DgvSellToClients);
            TpBuyTickets.Location = new Point(4, 29);
            TpBuyTickets.Name = "TpBuyTickets";
            TpBuyTickets.Padding = new Padding(3);
            TpBuyTickets.Size = new Size(1146, 641);
            TpBuyTickets.TabIndex = 0;
            TpBuyTickets.Text = "Купуване на билети";
            TpBuyTickets.UseVisualStyleBackColor = true;
            // 
            // ChBEmailAddressFilter
            // 
            ChBEmailAddressFilter.AutoSize = true;
            ChBEmailAddressFilter.Location = new Point(989, 240);
            ChBEmailAddressFilter.Name = "ChBEmailAddressFilter";
            ChBEmailAddressFilter.Size = new Size(18, 17);
            ChBEmailAddressFilter.TabIndex = 21;
            ChBEmailAddressFilter.UseVisualStyleBackColor = true;
            // 
            // ChBPhoneNumberFilter
            // 
            ChBPhoneNumberFilter.AutoSize = true;
            ChBPhoneNumberFilter.Location = new Point(989, 191);
            ChBPhoneNumberFilter.Name = "ChBPhoneNumberFilter";
            ChBPhoneNumberFilter.Size = new Size(18, 17);
            ChBPhoneNumberFilter.TabIndex = 20;
            ChBPhoneNumberFilter.UseVisualStyleBackColor = true;
            // 
            // ChBGenderFilter
            // 
            ChBGenderFilter.AutoSize = true;
            ChBGenderFilter.Location = new Point(989, 138);
            ChBGenderFilter.Name = "ChBGenderFilter";
            ChBGenderFilter.Size = new Size(18, 17);
            ChBGenderFilter.TabIndex = 19;
            ChBGenderFilter.UseVisualStyleBackColor = true;
            // 
            // ChBDateOfBirthFilter
            // 
            ChBDateOfBirthFilter.AutoSize = true;
            ChBDateOfBirthFilter.Location = new Point(989, 84);
            ChBDateOfBirthFilter.Name = "ChBDateOfBirthFilter";
            ChBDateOfBirthFilter.Size = new Size(18, 17);
            ChBDateOfBirthFilter.TabIndex = 18;
            ChBDateOfBirthFilter.UseVisualStyleBackColor = true;
            // 
            // ChBNameFilter
            // 
            ChBNameFilter.AutoSize = true;
            ChBNameFilter.Location = new Point(989, 31);
            ChBNameFilter.Name = "ChBNameFilter";
            ChBNameFilter.Size = new Size(18, 17);
            ChBNameFilter.TabIndex = 17;
            ChBNameFilter.UseVisualStyleBackColor = true;
            // 
            // LblTicketsPrice
            // 
            LblTicketsPrice.AutoSize = true;
            LblTicketsPrice.Location = new Point(1021, 563);
            LblTicketsPrice.Name = "LblTicketsPrice";
            LblTicketsPrice.Size = new Size(52, 20);
            LblTicketsPrice.TabIndex = 1;
            LblTicketsPrice.Text = "Цена: ";
            // 
            // BtnBuyTickets
            // 
            BtnBuyTickets.Location = new Point(1021, 592);
            BtnBuyTickets.Name = "BtnBuyTickets";
            BtnBuyTickets.Size = new Size(122, 41);
            BtnBuyTickets.TabIndex = 16;
            BtnBuyTickets.Text = "Купи";
            BtnBuyTickets.UseVisualStyleBackColor = true;
            BtnBuyTickets.Click += BtnBuyTickets_Click;
            // 
            // CbTicketClass
            // 
            CbTicketClass.FormattingEnabled = true;
            CbTicketClass.Items.AddRange(new object[] { "Икономическа", "Бизнес", "Първа" });
            CbTicketClass.Location = new Point(805, 605);
            CbTicketClass.Name = "CbTicketClass";
            CbTicketClass.Size = new Size(125, 28);
            CbTicketClass.TabIndex = 15;
            CbTicketClass.SelectedIndexChanged += CbTicketClass_SelectedIndexChanged;
            // 
            // TbTicketsNum
            // 
            TbTicketsNum.Location = new Point(805, 556);
            TbTicketsNum.Name = "TbTicketsNum";
            TbTicketsNum.Size = new Size(125, 27);
            TbTicketsNum.TabIndex = 14;
            TbTicketsNum.TextChanged += TbTicketsNum_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(805, 585);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Класа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(805, 534);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 12;
            label6.Text = "Брой билети";
            // 
            // BtnFilterClient
            // 
            BtnFilterClient.Location = new Point(805, 272);
            BtnFilterClient.Name = "BtnFilterClient";
            BtnFilterClient.Size = new Size(122, 41);
            BtnFilterClient.TabIndex = 11;
            BtnFilterClient.Text = "Филтър";
            BtnFilterClient.UseVisualStyleBackColor = true;
            BtnFilterClient.Click += BtnFilterClient_Click;
            // 
            // CbGender
            // 
            CbGender.FormattingEnabled = true;
            CbGender.Location = new Point(805, 132);
            CbGender.Name = "CbGender";
            CbGender.Size = new Size(178, 28);
            CbGender.TabIndex = 10;
            // 
            // DtpBirthday
            // 
            DtpBirthday.CustomFormat = "yyyy-MM-dd";
            DtpBirthday.Format = DateTimePickerFormat.Custom;
            DtpBirthday.Location = new Point(805, 79);
            DtpBirthday.Name = "DtpBirthday";
            DtpBirthday.Size = new Size(178, 27);
            DtpBirthday.TabIndex = 9;
            // 
            // TbEmailAddress
            // 
            TbEmailAddress.Location = new Point(805, 239);
            TbEmailAddress.Name = "TbEmailAddress";
            TbEmailAddress.Size = new Size(178, 27);
            TbEmailAddress.TabIndex = 8;
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Location = new Point(805, 186);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(178, 27);
            TbPhoneNumber.TabIndex = 7;
            // 
            // TbName
            // 
            TbName.Location = new Point(805, 26);
            TbName.Name = "TbName";
            TbName.Size = new Size(178, 27);
            TbName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(805, 3);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(805, 56);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Дата на раждане";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(805, 109);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 3;
            label3.Text = "Пол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(805, 163);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 4;
            label4.Text = "Телефонен номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(805, 216);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Имейл адрес";
            // 
            // DgvFlightsToSell
            // 
            DgvFlightsToSell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgvFlightsToSell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFlightsToSell.Location = new Point(0, 321);
            DgvFlightsToSell.Name = "DgvFlightsToSell";
            DgvFlightsToSell.RowHeadersWidth = 51;
            DgvFlightsToSell.Size = new Size(799, 320);
            DgvFlightsToSell.TabIndex = 1;
            DgvFlightsToSell.CellClick += DgvFlightsToSell_CellClick;
            // 
            // DgvSellToClients
            // 
            DgvSellToClients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgvSellToClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSellToClients.Location = new Point(0, 0);
            DgvSellToClients.Name = "DgvSellToClients";
            DgvSellToClients.RowHeadersWidth = 51;
            DgvSellToClients.Size = new Size(799, 320);
            DgvSellToClients.TabIndex = 0;
            DgvSellToClients.CellClick += DgvSellToClients_CellClick;
            // 
            // TpClients
            // 
            TpClients.Controls.Add(BtnDeleteClient);
            TpClients.Controls.Add(BtnUpdateClient);
            TpClients.Controls.Add(BtnCreateClient);
            TpClients.Controls.Add(DtpBirthdayClient);
            TpClients.Controls.Add(TbEmailAddressClient);
            TpClients.Controls.Add(TbPhoneNumberClient);
            TpClients.Controls.Add(TbNameClient);
            TpClients.Controls.Add(CbGenderClient);
            TpClients.Controls.Add(label13);
            TpClients.Controls.Add(label12);
            TpClients.Controls.Add(label11);
            TpClients.Controls.Add(label10);
            TpClients.Controls.Add(label9);
            TpClients.Controls.Add(DgvClients);
            TpClients.Location = new Point(4, 29);
            TpClients.Name = "TpClients";
            TpClients.Padding = new Padding(3);
            TpClients.Size = new Size(1146, 641);
            TpClients.TabIndex = 1;
            TpClients.Text = "Клиенти";
            TpClients.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteClient
            // 
            BtnDeleteClient.Location = new Point(1021, 101);
            BtnDeleteClient.Name = "BtnDeleteClient";
            BtnDeleteClient.Size = new Size(122, 41);
            BtnDeleteClient.TabIndex = 13;
            BtnDeleteClient.Text = "Изтрий";
            BtnDeleteClient.UseVisualStyleBackColor = true;
            BtnDeleteClient.Click += BtnDeleteClient_Click;
            // 
            // BtnUpdateClient
            // 
            BtnUpdateClient.Location = new Point(1021, 54);
            BtnUpdateClient.Name = "BtnUpdateClient";
            BtnUpdateClient.Size = new Size(122, 41);
            BtnUpdateClient.TabIndex = 12;
            BtnUpdateClient.Text = "Промени";
            BtnUpdateClient.UseVisualStyleBackColor = true;
            BtnUpdateClient.Click += BtnUpdateClient_Click;
            // 
            // BtnCreateClient
            // 
            BtnCreateClient.Location = new Point(1021, 6);
            BtnCreateClient.Name = "BtnCreateClient";
            BtnCreateClient.Size = new Size(122, 41);
            BtnCreateClient.TabIndex = 11;
            BtnCreateClient.Text = "Създай";
            BtnCreateClient.UseVisualStyleBackColor = true;
            BtnCreateClient.Click += BtnCreateClient_Click;
            // 
            // DtpBirthdayClient
            // 
            DtpBirthdayClient.CustomFormat = "yyyy-MM-dd";
            DtpBirthdayClient.Format = DateTimePickerFormat.Custom;
            DtpBirthdayClient.Location = new Point(805, 76);
            DtpBirthdayClient.Name = "DtpBirthdayClient";
            DtpBirthdayClient.Size = new Size(182, 27);
            DtpBirthdayClient.TabIndex = 10;
            // 
            // TbEmailAddressClient
            // 
            TbEmailAddressClient.Location = new Point(805, 230);
            TbEmailAddressClient.Name = "TbEmailAddressClient";
            TbEmailAddressClient.Size = new Size(182, 27);
            TbEmailAddressClient.TabIndex = 9;
            // 
            // TbPhoneNumberClient
            // 
            TbPhoneNumberClient.Location = new Point(805, 179);
            TbPhoneNumberClient.Name = "TbPhoneNumberClient";
            TbPhoneNumberClient.Size = new Size(182, 27);
            TbPhoneNumberClient.TabIndex = 8;
            // 
            // TbNameClient
            // 
            TbNameClient.Location = new Point(805, 25);
            TbNameClient.Name = "TbNameClient";
            TbNameClient.Size = new Size(182, 27);
            TbNameClient.TabIndex = 7;
            // 
            // CbGenderClient
            // 
            CbGenderClient.FormattingEnabled = true;
            CbGenderClient.Location = new Point(805, 127);
            CbGenderClient.Name = "CbGenderClient";
            CbGenderClient.Size = new Size(182, 28);
            CbGenderClient.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(805, 208);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 5;
            label13.Text = "Имейл адрес";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(805, 157);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 4;
            label12.Text = "Телефонен номер";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(805, 105);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 3;
            label11.Text = "Пол";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(805, 54);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 2;
            label10.Text = "Дата на раждане";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(805, 3);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 1;
            label9.Text = "Име";
            // 
            // DgvClients
            // 
            DgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClients.Location = new Point(0, 0);
            DgvClients.Name = "DgvClients";
            DgvClients.RowHeadersWidth = 51;
            DgvClients.Size = new Size(799, 641);
            DgvClients.TabIndex = 0;
            DgvClients.SelectionChanged += DgvClients_SelectionChanged;
            // 
            // TpPlanes
            // 
            TpPlanes.Controls.Add(BtnDeletePlane);
            TpPlanes.Controls.Add(BtnUpdatePlane);
            TpPlanes.Controls.Add(BtnCreatePlane);
            TpPlanes.Controls.Add(ChBHasFirstClassSeats);
            TpPlanes.Controls.Add(ChBHasBusinessSeats);
            TpPlanes.Controls.Add(ChBHasEconomySeats);
            TpPlanes.Controls.Add(ChBCanFly);
            TpPlanes.Controls.Add(TbFirstClassTicketsPrice);
            TpPlanes.Controls.Add(TbBusinessTicketsPrice);
            TpPlanes.Controls.Add(TbBusinessTicketsCount);
            TpPlanes.Controls.Add(TbEconomyTicketsPrice);
            TpPlanes.Controls.Add(TbFirstClassTicketsCount);
            TpPlanes.Controls.Add(TbEconomyTicketsCount);
            TpPlanes.Controls.Add(TbTotalSpaces);
            TpPlanes.Controls.Add(label35);
            TpPlanes.Controls.Add(label34);
            TpPlanes.Controls.Add(label32);
            TpPlanes.Controls.Add(label31);
            TpPlanes.Controls.Add(label29);
            TpPlanes.Controls.Add(label28);
            TpPlanes.Controls.Add(label25);
            TpPlanes.Controls.Add(DgvPlanes);
            TpPlanes.Location = new Point(4, 29);
            TpPlanes.Name = "TpPlanes";
            TpPlanes.Size = new Size(1146, 641);
            TpPlanes.TabIndex = 3;
            TpPlanes.Text = "Самолети";
            TpPlanes.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePlane
            // 
            BtnDeletePlane.Location = new Point(1021, 101);
            BtnDeletePlane.Name = "BtnDeletePlane";
            BtnDeletePlane.Size = new Size(122, 41);
            BtnDeletePlane.TabIndex = 29;
            BtnDeletePlane.Text = "Изтрий";
            BtnDeletePlane.UseVisualStyleBackColor = true;
            BtnDeletePlane.Click += BtnDeletePlane_Click;
            // 
            // BtnUpdatePlane
            // 
            BtnUpdatePlane.Location = new Point(1021, 54);
            BtnUpdatePlane.Name = "BtnUpdatePlane";
            BtnUpdatePlane.Size = new Size(122, 41);
            BtnUpdatePlane.TabIndex = 28;
            BtnUpdatePlane.Text = "Промени";
            BtnUpdatePlane.UseVisualStyleBackColor = true;
            BtnUpdatePlane.Click += BtnUpdatePlane_Click;
            // 
            // BtnCreatePlane
            // 
            BtnCreatePlane.Location = new Point(1021, 6);
            BtnCreatePlane.Name = "BtnCreatePlane";
            BtnCreatePlane.Size = new Size(122, 41);
            BtnCreatePlane.TabIndex = 27;
            BtnCreatePlane.Text = "Създай";
            BtnCreatePlane.UseVisualStyleBackColor = true;
            BtnCreatePlane.Click += BtnCreatePlane_Click;
            // 
            // ChBHasFirstClassSeats
            // 
            ChBHasFirstClassSeats.AutoSize = true;
            ChBHasFirstClassSeats.Location = new Point(805, 352);
            ChBHasFirstClassSeats.Name = "ChBHasFirstClassSeats";
            ChBHasFirstClassSeats.Size = new Size(202, 24);
            ChBHasFirstClassSeats.TabIndex = 26;
            ChBHasFirstClassSeats.Text = "Има 'Първа класа' места";
            ChBHasFirstClassSeats.UseVisualStyleBackColor = true;
            // 
            // ChBHasBusinessSeats
            // 
            ChBHasBusinessSeats.AutoSize = true;
            ChBHasBusinessSeats.Location = new Point(805, 219);
            ChBHasBusinessSeats.Name = "ChBHasBusinessSeats";
            ChBHasBusinessSeats.Size = new Size(158, 24);
            ChBHasBusinessSeats.TabIndex = 25;
            ChBHasBusinessSeats.Text = "Има бизнес места";
            ChBHasBusinessSeats.UseVisualStyleBackColor = true;
            // 
            // ChBHasEconomySeats
            // 
            ChBHasEconomySeats.AutoSize = true;
            ChBHasEconomySeats.Location = new Point(805, 86);
            ChBHasEconomySeats.Name = "ChBHasEconomySeats";
            ChBHasEconomySeats.Size = new Size(198, 24);
            ChBHasEconomySeats.TabIndex = 24;
            ChBHasEconomySeats.Text = "Има икономични места";
            ChBHasEconomySeats.UseVisualStyleBackColor = true;
            // 
            // ChBCanFly
            // 
            ChBCanFly.AutoSize = true;
            ChBCanFly.Location = new Point(805, 59);
            ChBCanFly.Name = "ChBCanFly";
            ChBCanFly.Size = new Size(133, 24);
            ChBCanFly.TabIndex = 23;
            ChBCanFly.Text = "Готов за полет";
            ChBCanFly.UseVisualStyleBackColor = true;
            // 
            // TbFirstClassTicketsPrice
            // 
            TbFirstClassTicketsPrice.Location = new Point(805, 455);
            TbFirstClassTicketsPrice.Name = "TbFirstClassTicketsPrice";
            TbFirstClassTicketsPrice.Size = new Size(182, 27);
            TbFirstClassTicketsPrice.TabIndex = 21;
            // 
            // TbBusinessTicketsPrice
            // 
            TbBusinessTicketsPrice.Location = new Point(805, 322);
            TbBusinessTicketsPrice.Name = "TbBusinessTicketsPrice";
            TbBusinessTicketsPrice.Size = new Size(182, 27);
            TbBusinessTicketsPrice.TabIndex = 20;
            // 
            // TbBusinessTicketsCount
            // 
            TbBusinessTicketsCount.Location = new Point(805, 269);
            TbBusinessTicketsCount.Name = "TbBusinessTicketsCount";
            TbBusinessTicketsCount.Size = new Size(182, 27);
            TbBusinessTicketsCount.TabIndex = 19;
            // 
            // TbEconomyTicketsPrice
            // 
            TbEconomyTicketsPrice.Location = new Point(805, 189);
            TbEconomyTicketsPrice.Name = "TbEconomyTicketsPrice";
            TbEconomyTicketsPrice.Size = new Size(182, 27);
            TbEconomyTicketsPrice.TabIndex = 18;
            // 
            // TbFirstClassTicketsCount
            // 
            TbFirstClassTicketsCount.Location = new Point(805, 402);
            TbFirstClassTicketsCount.Name = "TbFirstClassTicketsCount";
            TbFirstClassTicketsCount.Size = new Size(182, 27);
            TbFirstClassTicketsCount.TabIndex = 17;
            // 
            // TbEconomyTicketsCount
            // 
            TbEconomyTicketsCount.Location = new Point(805, 136);
            TbEconomyTicketsCount.Name = "TbEconomyTicketsCount";
            TbEconomyTicketsCount.Size = new Size(182, 27);
            TbEconomyTicketsCount.TabIndex = 16;
            // 
            // TbTotalSpaces
            // 
            TbTotalSpaces.Location = new Point(805, 29);
            TbTotalSpaces.Name = "TbTotalSpaces";
            TbTotalSpaces.Size = new Size(182, 27);
            TbTotalSpaces.TabIndex = 15;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(805, 432);
            label35.Name = "label35";
            label35.Size = new Size(207, 20);
            label35.TabIndex = 13;
            label35.Text = "Цена на 'Първа класа' билет";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(805, 379);
            label34.Name = "label34";
            label34.Size = new Size(195, 20);
            label34.TabIndex = 12;
            label34.Text = "Брой 'Първа класа' билети";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(805, 299);
            label32.Name = "label32";
            label32.Size = new Size(163, 20);
            label32.TabIndex = 10;
            label32.Text = "Цена на бизнес билет";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(805, 246);
            label31.Name = "label31";
            label31.Size = new Size(151, 20);
            label31.TabIndex = 9;
            label31.Text = "Брой бизнес билети";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(805, 166);
            label29.Name = "label29";
            label29.Size = new Size(202, 20);
            label29.TabIndex = 7;
            label29.Text = "Цена на иконимичен билет";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(805, 113);
            label28.Name = "label28";
            label28.Size = new Size(191, 20);
            label28.TabIndex = 6;
            label28.Text = "Брой икономични билети";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(805, 6);
            label25.Name = "label25";
            label25.Size = new Size(94, 20);
            label25.TabIndex = 3;
            label25.Text = "Общо места";
            // 
            // DgvPlanes
            // 
            DgvPlanes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPlanes.Location = new Point(0, 0);
            DgvPlanes.Name = "DgvPlanes";
            DgvPlanes.RowHeadersWidth = 51;
            DgvPlanes.Size = new Size(799, 641);
            DgvPlanes.TabIndex = 0;
            // 
            // TpUsers
            // 
            TpUsers.Controls.Add(BtnCreateUser);
            TpUsers.Controls.Add(BtnUpdateUser);
            TpUsers.Controls.Add(BtnDeleteUser);
            TpUsers.Controls.Add(DtpBirthdayUsers);
            TpUsers.Controls.Add(TbPasswordUser);
            TpUsers.Controls.Add(TbUsernameUsers);
            TpUsers.Controls.Add(TbEmailAddressUsers);
            TpUsers.Controls.Add(TbPhoneNumberUsers);
            TpUsers.Controls.Add(TbNameUsers);
            TpUsers.Controls.Add(CbGendersUsers);
            TpUsers.Controls.Add(CbUserTypeUsers);
            TpUsers.Controls.Add(ChBLockedUser);
            TpUsers.Controls.Add(label37);
            TpUsers.Controls.Add(label36);
            TpUsers.Controls.Add(label33);
            TpUsers.Controls.Add(label30);
            TpUsers.Controls.Add(label27);
            TpUsers.Controls.Add(label26);
            TpUsers.Controls.Add(label24);
            TpUsers.Controls.Add(label23);
            TpUsers.Controls.Add(DgvUsers);
            TpUsers.Location = new Point(4, 29);
            TpUsers.Name = "TpUsers";
            TpUsers.Size = new Size(1146, 641);
            TpUsers.TabIndex = 4;
            TpUsers.Text = "Потребители";
            TpUsers.UseVisualStyleBackColor = true;
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.Location = new Point(1021, 6);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(122, 41);
            BtnCreateUser.TabIndex = 1;
            BtnCreateUser.Text = "Създай";
            BtnCreateUser.UseVisualStyleBackColor = true;
            BtnCreateUser.Click += BtnCreateUser_Click;
            // 
            // BtnUpdateUser
            // 
            BtnUpdateUser.Location = new Point(1021, 54);
            BtnUpdateUser.Name = "BtnUpdateUser";
            BtnUpdateUser.Size = new Size(122, 41);
            BtnUpdateUser.TabIndex = 2;
            BtnUpdateUser.Text = "Промени";
            BtnUpdateUser.UseVisualStyleBackColor = true;
            BtnUpdateUser.Click += BtnUpdateUser_Click;
            // 
            // BtnDeleteUser
            // 
            BtnDeleteUser.Location = new Point(1021, 101);
            BtnDeleteUser.Name = "BtnDeleteUser";
            BtnDeleteUser.Size = new Size(122, 41);
            BtnDeleteUser.TabIndex = 3;
            BtnDeleteUser.Text = "Изтрий";
            BtnDeleteUser.UseVisualStyleBackColor = true;
            BtnDeleteUser.Click += BtnDeleteUser_Click;
            // 
            // DtpBirthdayUsers
            // 
            DtpBirthdayUsers.Location = new Point(805, 128);
            DtpBirthdayUsers.Name = "DtpBirthdayUsers";
            DtpBirthdayUsers.Size = new Size(182, 27);
            DtpBirthdayUsers.TabIndex = 17;
            // 
            // TbPasswordUser
            // 
            TbPasswordUser.Location = new Point(805, 384);
            TbPasswordUser.Name = "TbPasswordUser";
            TbPasswordUser.PasswordChar = '*';
            TbPasswordUser.Size = new Size(182, 27);
            TbPasswordUser.TabIndex = 16;
            // 
            // TbUsernameUsers
            // 
            TbUsernameUsers.Location = new Point(805, 333);
            TbUsernameUsers.Name = "TbUsernameUsers";
            TbUsernameUsers.Size = new Size(182, 27);
            TbUsernameUsers.TabIndex = 15;
            // 
            // TbEmailAddressUsers
            // 
            TbEmailAddressUsers.Location = new Point(805, 282);
            TbEmailAddressUsers.Name = "TbEmailAddressUsers";
            TbEmailAddressUsers.Size = new Size(182, 27);
            TbEmailAddressUsers.TabIndex = 14;
            // 
            // TbPhoneNumberUsers
            // 
            TbPhoneNumberUsers.Location = new Point(805, 231);
            TbPhoneNumberUsers.Name = "TbPhoneNumberUsers";
            TbPhoneNumberUsers.Size = new Size(182, 27);
            TbPhoneNumberUsers.TabIndex = 13;
            // 
            // TbNameUsers
            // 
            TbNameUsers.Location = new Point(805, 77);
            TbNameUsers.Name = "TbNameUsers";
            TbNameUsers.Size = new Size(182, 27);
            TbNameUsers.TabIndex = 12;
            // 
            // CbGendersUsers
            // 
            CbGendersUsers.FormattingEnabled = true;
            CbGendersUsers.Location = new Point(805, 179);
            CbGendersUsers.Name = "CbGendersUsers";
            CbGendersUsers.Size = new Size(182, 28);
            CbGendersUsers.TabIndex = 11;
            // 
            // CbUserTypeUsers
            // 
            CbUserTypeUsers.FormattingEnabled = true;
            CbUserTypeUsers.Location = new Point(805, 25);
            CbUserTypeUsers.Name = "CbUserTypeUsers";
            CbUserTypeUsers.Size = new Size(182, 28);
            CbUserTypeUsers.TabIndex = 10;
            // 
            // ChBLockedUser
            // 
            ChBLockedUser.AutoSize = true;
            ChBLockedUser.Location = new Point(805, 413);
            ChBLockedUser.Name = "ChBLockedUser";
            ChBLockedUser.Size = new Size(184, 24);
            ChBLockedUser.TabIndex = 9;
            ChBLockedUser.Text = "Заключен потребител";
            ChBLockedUser.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(805, 362);
            label37.Name = "label37";
            label37.Size = new Size(62, 20);
            label37.TabIndex = 8;
            label37.Text = "Парола";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(805, 311);
            label36.Name = "label36";
            label36.Size = new Size(147, 20);
            label36.TabIndex = 7;
            label36.Text = "Потребителско име";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(805, 260);
            label33.Name = "label33";
            label33.Size = new Size(56, 20);
            label33.TabIndex = 6;
            label33.Text = "Имейл";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(805, 209);
            label30.Name = "label30";
            label30.Size = new Size(136, 20);
            label30.TabIndex = 5;
            label30.Text = "Телефонен номер";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(805, 157);
            label27.Name = "label27";
            label27.Size = new Size(37, 20);
            label27.TabIndex = 4;
            label27.Text = "Пол";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(805, 106);
            label26.Name = "label26";
            label26.Size = new Size(127, 20);
            label26.TabIndex = 3;
            label26.Text = "Дата на раждане";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(805, 55);
            label24.Name = "label24";
            label24.Size = new Size(39, 20);
            label24.TabIndex = 2;
            label24.Text = "Име";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(805, 3);
            label23.Name = "label23";
            label23.Size = new Size(143, 20);
            label23.TabIndex = 1;
            label23.Text = "Потребителски тип";
            // 
            // DgvUsers
            // 
            DgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsers.Location = new Point(0, 0);
            DgvUsers.Name = "DgvUsers";
            DgvUsers.RowHeadersWidth = 51;
            DgvUsers.Size = new Size(799, 641);
            DgvUsers.TabIndex = 0;
            // 
            // TpSoldTickets
            // 
            TpSoldTickets.Controls.Add(DgvTicketsSold);
            TpSoldTickets.Location = new Point(4, 29);
            TpSoldTickets.Name = "TpSoldTickets";
            TpSoldTickets.Size = new Size(1146, 641);
            TpSoldTickets.TabIndex = 5;
            TpSoldTickets.Text = "Продадени билети";
            TpSoldTickets.UseVisualStyleBackColor = true;
            // 
            // DgvTicketsSold
            // 
            DgvTicketsSold.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvTicketsSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTicketsSold.Location = new Point(0, 0);
            DgvTicketsSold.Name = "DgvTicketsSold";
            DgvTicketsSold.RowHeadersWidth = 51;
            DgvTicketsSold.Size = new Size(799, 641);
            DgvTicketsSold.TabIndex = 0;
            // 
            // TpLog
            // 
            TpLog.Controls.Add(DgvLoginLog);
            TpLog.Location = new Point(4, 29);
            TpLog.Name = "TpLog";
            TpLog.Padding = new Padding(3);
            TpLog.Size = new Size(1146, 641);
            TpLog.TabIndex = 6;
            TpLog.Text = "Лог на потребители";
            TpLog.UseVisualStyleBackColor = true;
            // 
            // DgvLoginLog
            // 
            DgvLoginLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLoginLog.Location = new Point(0, 0);
            DgvLoginLog.Name = "DgvLoginLog";
            DgvLoginLog.RowHeadersWidth = 51;
            DgvLoginLog.Size = new Size(799, 641);
            DgvLoginLog.TabIndex = 0;
            // 
            // FrmAirportMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1154, 674);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAirportMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Самолетни системи";
            Load += FrmAirportMain_Load;
            TpFlights.ResumeLayout(false);
            TpFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFlights).EndInit();
            tabControl1.ResumeLayout(false);
            TpBuyTickets.ResumeLayout(false);
            TpBuyTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvFlightsToSell).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSellToClients).EndInit();
            TpClients.ResumeLayout(false);
            TpClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvClients).EndInit();
            TpPlanes.ResumeLayout(false);
            TpPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPlanes).EndInit();
            TpUsers.ResumeLayout(false);
            TpUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsers).EndInit();
            TpSoldTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTicketsSold).EndInit();
            TpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvLoginLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TpBuyTickets;
        private TabPage TpClients;
        private TabPage TpFlights;
        private TabPage TpPlanes;
        private TabPage TpUsers;
        private TabPage TpSoldTickets;
        private DataGridView DgvSellToClients;
        private DataGridView DgvFlights;
        private DataGridView DgvPlanes;
        private DataGridView DgvUsers;
        private DataGridView DgvTicketsSold;
        private DataGridView DgvFlightsToSell;
        private DataGridView DgvClients;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnFilterClient;
        private ComboBox CbGender;
        private DateTimePicker DtpBirthday;
        private TextBox TbEmailAddress;
        private TextBox TbPhoneNumber;
        private TextBox TbName;
        private Button BtnBuyTickets;
        private ComboBox CbTicketClass;
        private TextBox TbTicketsNum;
        private Label label7;
        private Label label6;
        private Label LblTicketsPrice;
        private TextBox TbEmailAddressClient;
        private TextBox TbPhoneNumberClient;
        private TextBox TbNameClient;
        private ComboBox CbGenderClient;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker DtpBirthdayClient;
        private Button BtnDeleteClient;
        private Button BtnUpdateClient;
        private Button BtnCreateClient;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox TbDelayMinutes;
        private TextBox TbReason;
        private TextBox TbFreeSpaces;
        private TextBox TbToAirport;
        private TextBox TbFromAirport;
        private ComboBox CbFlightSituationId;
        private ComboBox CbPlaneId;
        private DateTimePicker DtpLandingTime;
        private DateTimePicker DtpTakeOffTime;
        private Button BtnDeleteFlight;
        private Button BtnUpdateFlight;
        private Button BtnCreateFlight;
        private Label label31;
        private Label label29;
        private Label label28;
        private Label label25;
        private Label label35;
        private Label label34;
        private Label label32;
        private TextBox TbFirstClassTicketsPrice;
        private TextBox TbBusinessTicketsPrice;
        private TextBox TbBusinessTicketsCount;
        private TextBox TbEconomyTicketsPrice;
        private TextBox TbFirstClassTicketsCount;
        private TextBox TbEconomyTicketsCount;
        private TextBox TbTotalSpaces;
        private CheckBox ChBHasFirstClassSeats;
        private CheckBox ChBHasBusinessSeats;
        private CheckBox ChBHasEconomySeats;
        private CheckBox ChBCanFly;
        private Button BtnDeletePlane;
        private Button BtnUpdatePlane;
        private Button BtnCreatePlane;
        private TabPage TpLog;
        private DataGridView DgvLoginLog;
        private Label label26;
        private Label label24;
        private Label label23;
        private Label label37;
        private Label label36;
        private Label label33;
        private Label label30;
        private Label label27;
        private TextBox TbPasswordUser;
        private TextBox TbUsernameUsers;
        private TextBox TbEmailAddressUsers;
        private TextBox TbPhoneNumberUsers;
        private TextBox TbNameUsers;
        private ComboBox CbGendersUsers;
        private ComboBox CbUserTypeUsers;
        private CheckBox ChBLockedUser;
        private DateTimePicker DtpBirthdayUsers;
        private Button BtnCreateUser;
        private Button BtnUpdateUser;
        private Button BtnDeleteUser;
        private CheckBox ChBEmailAddressFilter;
        private CheckBox ChBPhoneNumberFilter;
        private CheckBox ChBGenderFilter;
        private CheckBox ChBDateOfBirthFilter;
        private CheckBox ChBNameFilter;
    }
}
