namespace basic
{
    partial class Formular
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBasicInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTshirtInfo = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(25, 97);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(155, 27);
            this.txtNume.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // lblBasicInfo
            // 
            this.lblBasicInfo.AutoSize = true;
            this.lblBasicInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBasicInfo.Location = new System.Drawing.Point(25, 26);
            this.lblBasicInfo.Name = "lblBasicInfo";
            this.lblBasicInfo.Size = new System.Drawing.Size(94, 28);
            this.lblBasicInfo.TabIndex = 5;
            this.lblBasicInfo.Text = "Basic Info";
            this.lblBasicInfo.Click += new System.EventHandler(this.lblBasicInfo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: *";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Adress: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Job Role";
            // 
            // lblTshirtInfo
            // 
            this.lblTshirtInfo.AutoSize = true;
            this.lblTshirtInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTshirtInfo.Location = new System.Drawing.Point(426, 26);
            this.lblTshirtInfo.Name = "lblTshirtInfo";
            this.lblTshirtInfo.Size = new System.Drawing.Size(110, 28);
            this.lblTshirtInfo.TabIndex = 9;
            this.lblTshirtInfo.Text = "T-Shirt Info";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(426, 74);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 20);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size:";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "XXS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cmbSize.Location = new System.Drawing.Point(426, 97);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(48, 28);
            this.cmbSize.TabIndex = 11;
            this.cmbSize.Text = "M";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Location = new System.Drawing.Point(520, 74);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(62, 20);
            this.lblDesign.TabIndex = 12;
            this.lblDesign.Text = "Design: ";
            this.lblDesign.Click += new System.EventHandler(this.lblDesign_Click);
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Floral",
            "Tie dye",
            "Solid color",
            "Message"});
            this.cmbTheme.Location = new System.Drawing.Point(520, 97);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(136, 28);
            this.cmbTheme.TabIndex = 13;
            this.cmbTheme.Text = "Select Theme";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(426, 143);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 20);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color:";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Secretary",
            "Engineer"});
            this.cmbRole.Location = new System.Drawing.Point(25, 252);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(151, 28);
            this.cmbRole.TabIndex = 16;
            this.cmbRole.Text = "Select Job Role";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "White",
            "Blue",
            "Purple",
            "Yellow"});
            this.cmbColor.Location = new System.Drawing.Point(426, 175);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(230, 28);
            this.cmbColor.TabIndex = 17;
            this.cmbColor.Text = "Select a design theme above";
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(426, 244);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(172, 36);
            this.buttonData.TabIndex = 18;
            this.buttonData.Text = "Click to show info";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(643, 384);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(124, 43);
            this.buttonSubmit.TabIndex = 19;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click_1);
            // 
            // Formular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTshirtInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBasicInfo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNume);
            this.Name = "Formular";
            this.Text = "Formular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNume;
        private TextBox txtEmail;
        private Label lblBasicInfo;
        private Label lblName;
        private Label lblEmail;
        private Label label1;
        private Label lblTshirtInfo;
        private Label lblSize;
        private ComboBox cmbSize;
        private Label lblDesign;
        private ComboBox cmbTheme;
        private Label lblColor;
        private ComboBox cmbRole;
        private ComboBox cmbColor;
        private Button buttonData;
        private Button buttonSubmit;
    }
}