namespace basic
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmergency = new System.Windows.Forms.TextBox();
            this.lblParking = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblaRestrictions = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxNone = new System.Windows.Forms.CheckBox();
            this.cbxVegetarian = new System.Windows.Forms.CheckBox();
            this.cbxGluten = new System.Windows.Forms.CheckBox();
            this.cbxLactose = new System.Windows.Forms.CheckBox();
            this.cbxNut = new System.Windows.Forms.CheckBox();
            this.cbxShellfish = new System.Windows.Forms.CheckBox();
            this.cbxGala = new System.Windows.Forms.CheckBox();
            this.cbxLuncheon = new System.Windows.Forms.CheckBox();
            this.cbxHall = new System.Windows.Forms.CheckBox();
            this.lblList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnShared = new System.Windows.Forms.RadioButton();
            this.rbtnNoRoom = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnNo2 = new System.Windows.Forms.RadioButton();
            this.rbtnYes2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.Location = new System.Drawing.Point(319, 49);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(339, 26);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "General Admission Registration";
            this.lblRegistration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(14, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleDescription = "";
            this.txtFirstName.AccessibleName = "";
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(112, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(102, 27);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Tag = "";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(228, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(112, 27);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(13, 192);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(112, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "sample@example.com";
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(12, 243);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 22);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(12, 292);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 22);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmergency
            // 
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmergency.Location = new System.Drawing.Point(12, 341);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(162, 22);
            this.lblEmergency.TabIndex = 10;
            this.lblEmergency.Text = "Emergency Contact";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(112, 287);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 27);
            this.txtPhone.TabIndex = 11;
            // 
            // txtEmergency
            // 
            this.txtEmergency.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmergency.Location = new System.Drawing.Point(112, 375);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(228, 27);
            this.txtEmergency.TabIndex = 12;
            this.txtEmergency.TextChanged += new System.EventHandler(this.txtEmergency_TextChanged);
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParking.Location = new System.Drawing.Point(13, 424);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(202, 22);
            this.lblParking.TabIndex = 13;
            this.lblParking.Text = "Do you require parking?";
            this.lblParking.Click += new System.EventHandler(this.lblParking_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoom.Location = new System.Drawing.Point(13, 460);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(254, 22);
            this.lblRoom.TabIndex = 17;
            this.lblRoom.Text = "What is your room preference?";
            // 
            // lblaRestrictions
            // 
            this.lblaRestrictions.AutoSize = true;
            this.lblaRestrictions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblaRestrictions.Location = new System.Drawing.Point(619, 139);
            this.lblaRestrictions.Name = "lblaRestrictions";
            this.lblaRestrictions.Size = new System.Drawing.Size(272, 22);
            this.lblaRestrictions.TabIndex = 21;
            this.lblaRestrictions.Text = "Do you have dietary restrictions?";
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivities.Location = new System.Drawing.Point(619, 341);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(261, 22);
            this.lblActivities.TabIndex = 28;
            this.lblActivities.Text = "What activities will you attend?";
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(813, 599);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(170, 47);
            this.btnInfo.TabIndex = 34;
            this.btnInfo.Text = "Click to show info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AllowDrop = true;
            this.btnSubmit.AutoEllipsis = true;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(889, 662);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxNone
            // 
            this.cbxNone.AutoSize = true;
            this.cbxNone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNone.Location = new System.Drawing.Point(665, 164);
            this.cbxNone.Name = "cbxNone";
            this.cbxNone.Size = new System.Drawing.Size(68, 23);
            this.cbxNone.TabIndex = 43;
            this.cbxNone.Text = "None";
            this.cbxNone.UseVisualStyleBackColor = true;
            // 
            // cbxVegetarian
            // 
            this.cbxVegetarian.AutoSize = true;
            this.cbxVegetarian.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxVegetarian.Location = new System.Drawing.Point(665, 189);
            this.cbxVegetarian.Name = "cbxVegetarian";
            this.cbxVegetarian.Size = new System.Drawing.Size(102, 23);
            this.cbxVegetarian.TabIndex = 44;
            this.cbxVegetarian.Text = "Vegetarian";
            this.cbxVegetarian.UseVisualStyleBackColor = true;
            // 
            // cbxGluten
            // 
            this.cbxGluten.AutoSize = true;
            this.cbxGluten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxGluten.Location = new System.Drawing.Point(665, 218);
            this.cbxGluten.Name = "cbxGluten";
            this.cbxGluten.Size = new System.Drawing.Size(131, 23);
            this.cbxGluten.TabIndex = 45;
            this.cbxGluten.Text = "Gluten Allergy";
            this.cbxGluten.UseVisualStyleBackColor = true;
            // 
            // cbxLactose
            // 
            this.cbxLactose.AutoSize = true;
            this.cbxLactose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxLactose.Location = new System.Drawing.Point(665, 247);
            this.cbxLactose.Name = "cbxLactose";
            this.cbxLactose.Size = new System.Drawing.Size(139, 23);
            this.cbxLactose.TabIndex = 46;
            this.cbxLactose.Text = "Lactose Allergy";
            this.cbxLactose.UseVisualStyleBackColor = true;
            // 
            // cbxNut
            // 
            this.cbxNut.AutoSize = true;
            this.cbxNut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNut.Location = new System.Drawing.Point(665, 276);
            this.cbxNut.Name = "cbxNut";
            this.cbxNut.Size = new System.Drawing.Size(110, 23);
            this.cbxNut.TabIndex = 47;
            this.cbxNut.Text = "Nut Allergy";
            this.cbxNut.UseVisualStyleBackColor = true;
            // 
            // cbxShellfish
            // 
            this.cbxShellfish.AutoSize = true;
            this.cbxShellfish.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxShellfish.Location = new System.Drawing.Point(665, 305);
            this.cbxShellfish.Name = "cbxShellfish";
            this.cbxShellfish.Size = new System.Drawing.Size(146, 23);
            this.cbxShellfish.TabIndex = 48;
            this.cbxShellfish.Text = "Shellfish Allergy";
            this.cbxShellfish.UseVisualStyleBackColor = true;
            // 
            // cbxGala
            // 
            this.cbxGala.AutoSize = true;
            this.cbxGala.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxGala.Location = new System.Drawing.Point(665, 366);
            this.cbxGala.Name = "cbxGala";
            this.cbxGala.Size = new System.Drawing.Size(165, 23);
            this.cbxGala.TabIndex = 49;
            this.cbxGala.Text = "Awards Gala Dinner";
            this.cbxGala.UseVisualStyleBackColor = true;
            // 
            // cbxLuncheon
            // 
            this.cbxLuncheon.AutoSize = true;
            this.cbxLuncheon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxLuncheon.Location = new System.Drawing.Point(665, 395);
            this.cbxLuncheon.Name = "cbxLuncheon";
            this.cbxLuncheon.Size = new System.Drawing.Size(98, 23);
            this.cbxLuncheon.TabIndex = 50;
            this.cbxLuncheon.Text = "Luncheon";
            this.cbxLuncheon.UseVisualStyleBackColor = true;
            // 
            // cbxHall
            // 
            this.cbxHall.AutoSize = true;
            this.cbxHall.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxHall.Location = new System.Drawing.Point(665, 424);
            this.cbxHall.Name = "cbxHall";
            this.cbxHall.Size = new System.Drawing.Size(100, 23);
            this.cbxHall.TabIndex = 51;
            this.cbxHall.Text = "Town Hall";
            this.cbxHall.UseVisualStyleBackColor = true;
            // 
            // lblList
            // 
            this.lblList.AccessibleDescription = "";
            this.lblList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblList.Location = new System.Drawing.Point(619, 450);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(289, 74);
            this.lblList.TabIndex = 22;
            this.lblList.Text = "Do you want to see the list of other attendees and their profiles on the official" +
    " event app?";
            this.lblList.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(112, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 61);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale.Location = new System.Drawing.Point(142, 21);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(80, 23);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale.Location = new System.Drawing.Point(6, 21);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(65, 23);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnSingle.Location = new System.Drawing.Point(6, 26);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(119, 23);
            this.rbtnSingle.TabIndex = 55;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single Room";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            this.rbtnSingle.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnYes.Location = new System.Drawing.Point(6, 16);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(54, 23);
            this.rbtnYes.TabIndex = 56;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnNo);
            this.groupBox2.Controls.Add(this.rbtnYes);
            this.groupBox2.Location = new System.Drawing.Point(221, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 47);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnNo.Location = new System.Drawing.Point(66, 16);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(51, 23);
            this.rbtnNo.TabIndex = 57;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnNoRoom);
            this.groupBox3.Controls.Add(this.rbtnShared);
            this.groupBox3.Controls.Add(this.rbtnSingle);
            this.groupBox3.Location = new System.Drawing.Point(112, 485);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 123);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // rbtnShared
            // 
            this.rbtnShared.AutoSize = true;
            this.rbtnShared.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnShared.Location = new System.Drawing.Point(6, 55);
            this.rbtnShared.Name = "rbtnShared";
            this.rbtnShared.Size = new System.Drawing.Size(122, 23);
            this.rbtnShared.TabIndex = 56;
            this.rbtnShared.TabStop = true;
            this.rbtnShared.Text = "Shared Room";
            this.rbtnShared.UseVisualStyleBackColor = true;
            this.rbtnShared.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnNoRoom
            // 
            this.rbtnNoRoom.AutoSize = true;
            this.rbtnNoRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnNoRoom.Location = new System.Drawing.Point(6, 84);
            this.rbtnNoRoom.Name = "rbtnNoRoom";
            this.rbtnNoRoom.Size = new System.Drawing.Size(153, 23);
            this.rbtnNoRoom.TabIndex = 57;
            this.rbtnNoRoom.TabStop = true;
            this.rbtnNoRoom.Text = "No Room Needed";
            this.rbtnNoRoom.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnYes2);
            this.groupBox4.Controls.Add(this.rbtnNo2);
            this.groupBox4.Location = new System.Drawing.Point(665, 524);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 49);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            // 
            // rbtnNo2
            // 
            this.rbtnNo2.AutoSize = true;
            this.rbtnNo2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnNo2.Location = new System.Drawing.Point(95, 16);
            this.rbtnNo2.Name = "rbtnNo2";
            this.rbtnNo2.Size = new System.Drawing.Size(51, 23);
            this.rbtnNo2.TabIndex = 0;
            this.rbtnNo2.TabStop = true;
            this.rbtnNo2.Text = "No";
            this.rbtnNo2.UseVisualStyleBackColor = true;
            this.rbtnNo2.CheckedChanged += new System.EventHandler(this.rbtnNo2_CheckedChanged);
            // 
            // rbtnYes2
            // 
            this.rbtnYes2.AutoSize = true;
            this.rbtnYes2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnYes2.Location = new System.Drawing.Point(6, 16);
            this.rbtnYes2.Name = "rbtnYes2";
            this.rbtnYes2.Size = new System.Drawing.Size(54, 23);
            this.rbtnYes2.TabIndex = 1;
            this.rbtnYes2.TabStop = true;
            this.rbtnYes2.Text = "Yes";
            this.rbtnYes2.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxHall);
            this.Controls.Add(this.cbxLuncheon);
            this.Controls.Add(this.cbxGala);
            this.Controls.Add(this.cbxShellfish);
            this.Controls.Add(this.cbxNut);
            this.Controls.Add(this.cbxLactose);
            this.Controls.Add(this.cbxGluten);
            this.Controls.Add(this.cbxVegetarian);
            this.Controls.Add(this.cbxNone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblaRestrictions);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.txtEmergency);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmergency);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegistration);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegistration;
        private Label lblName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGender;
        private Label lblPhone;
        private Label lblEmergency;
        private TextBox txtPhone;
        private TextBox txtEmergency;
        private Label lblParking;
        private Label lblRoom;
        private Label lblaRestrictions;
        private Label lblActivities;
        private Button btnInfo;
        private Button btnSubmit;
        private CheckBox cbxNone;
        private CheckBox cbxVegetarian;
        private CheckBox cbxGluten;
        private CheckBox cbxLactose;
        private CheckBox cbxNut;
        private CheckBox cbxShellfish;
        private CheckBox cbxGala;
        private CheckBox cbxLuncheon;
        private CheckBox cbxHall;
        private Label lblList;
        private GroupBox groupBox1;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private RadioButton rbtnSingle;
        private RadioButton rbtnYes;
        private GroupBox groupBox2;
        private RadioButton rbtnNo;
        private GroupBox groupBox3;
        private RadioButton rbtnNoRoom;
        private RadioButton rbtnShared;
        private GroupBox groupBox4;
        private RadioButton rbtnYes2;
        private RadioButton rbtnNo2;
    }
}