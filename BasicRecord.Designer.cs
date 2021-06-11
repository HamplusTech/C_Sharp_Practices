namespace C_Sharp_Practices
{
    partial class BasicRecord
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cboLGA = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboLGA
            // 
            this.cboLGA.FormattingEnabled = true;
            this.cboLGA.Items.AddRange(new object[] {
            "*** select from list ***",
            "Abakaliki",
            "Ebonyi",
            "Ezeagu",
            "Udi",
            "Nkanu-East"});
            this.cboLGA.Location = new System.Drawing.Point(161, 169);
            this.cboLGA.Name = "cboLGA";
            this.cboLGA.Size = new System.Drawing.Size(163, 21);
            this.cboLGA.TabIndex = 24;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "*** select from list ***",
            "Ebonyi",
            "Enugu"});
            this.cboState.Location = new System.Drawing.Point(161, 139);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(163, 21);
            this.cboState.TabIndex = 23;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(161, 108);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(163, 20);
            this.txtLocation.TabIndex = 22;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(161, 77);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(163, 20);
            this.txtPN.TabIndex = 21;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "*** select from list ***",
            "Male",
            "Female"});
            this.cboSex.Location = new System.Drawing.Point(161, 47);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(163, 21);
            this.cboSex.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 19;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(25, 172);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 18;
            this.Label6.Text = "LGA";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(25, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 13);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "State";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(25, 111);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Location";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 84);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Phone Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(25, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(25, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Sex";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Name";
            // 
            // BasicRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 268);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboLGA);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "BasicRecord";
            this.Text = "BasicRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ComboBox cboLGA;
        internal System.Windows.Forms.ComboBox cboState;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.TextBox txtPN;
        internal System.Windows.Forms.ComboBox cboSex;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}