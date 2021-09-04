
namespace AccessControl.Forms
{
    partial class frmRegisterInOut
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
            this.gbStarship = new System.Windows.Forms.GroupBox();
            this.lblStarshipClass = new System.Windows.Forms.Label();
            this.txtStarshipClass = new System.Windows.Forms.Label();
            this.lblStarshipModel = new System.Windows.Forms.Label();
            this.txtStarshipModel = new System.Windows.Forms.Label();
            this.lblStarshipName = new System.Windows.Forms.Label();
            this.txtStarshipName = new System.Windows.Forms.Label();
            this.gbPilot = new System.Windows.Forms.GroupBox();
            this.lblPilotPlanetName = new System.Windows.Forms.Label();
            this.txtPlanetName = new System.Windows.Forms.Label();
            this.lblPilotBirthYear = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.Label();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.txtPilotName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gbAlerts = new System.Windows.Forms.GroupBox();
            this.lvAlerts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.gbStarship.SuspendLayout();
            this.gbPilot.SuspendLayout();
            this.gbAlerts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStarship
            // 
            this.gbStarship.Controls.Add(this.lblStarshipClass);
            this.gbStarship.Controls.Add(this.txtStarshipClass);
            this.gbStarship.Controls.Add(this.lblStarshipModel);
            this.gbStarship.Controls.Add(this.txtStarshipModel);
            this.gbStarship.Controls.Add(this.lblStarshipName);
            this.gbStarship.Controls.Add(this.txtStarshipName);
            this.gbStarship.Location = new System.Drawing.Point(14, 69);
            this.gbStarship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStarship.Name = "gbStarship";
            this.gbStarship.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStarship.Size = new System.Drawing.Size(371, 167);
            this.gbStarship.TabIndex = 0;
            this.gbStarship.TabStop = false;
            this.gbStarship.Text = "Starship";
            // 
            // lblStarshipClass
            // 
            this.lblStarshipClass.AutoSize = true;
            this.lblStarshipClass.Location = new System.Drawing.Point(16, 119);
            this.lblStarshipClass.Name = "lblStarshipClass";
            this.lblStarshipClass.Size = new System.Drawing.Size(45, 20);
            this.lblStarshipClass.TabIndex = 5;
            this.lblStarshipClass.Text = "Class:";
            // 
            // txtStarshipClass
            // 
            this.txtStarshipClass.AutoSize = true;
            this.txtStarshipClass.Location = new System.Drawing.Point(74, 119);
            this.txtStarshipClass.Name = "txtStarshipClass";
            this.txtStarshipClass.Size = new System.Drawing.Size(18, 20);
            this.txtStarshipClass.TabIndex = 4;
            this.txtStarshipClass.Text = "...";
            // 
            // lblStarshipModel
            // 
            this.lblStarshipModel.AutoSize = true;
            this.lblStarshipModel.Location = new System.Drawing.Point(7, 81);
            this.lblStarshipModel.Name = "lblStarshipModel";
            this.lblStarshipModel.Size = new System.Drawing.Size(55, 20);
            this.lblStarshipModel.TabIndex = 3;
            this.lblStarshipModel.Text = "Model:";
            // 
            // txtStarshipModel
            // 
            this.txtStarshipModel.AutoSize = true;
            this.txtStarshipModel.Location = new System.Drawing.Point(74, 81);
            this.txtStarshipModel.Name = "txtStarshipModel";
            this.txtStarshipModel.Size = new System.Drawing.Size(18, 20);
            this.txtStarshipModel.TabIndex = 2;
            this.txtStarshipModel.Text = "...";
            // 
            // lblStarshipName
            // 
            this.lblStarshipName.AutoSize = true;
            this.lblStarshipName.Location = new System.Drawing.Point(16, 44);
            this.lblStarshipName.Name = "lblStarshipName";
            this.lblStarshipName.Size = new System.Drawing.Size(52, 20);
            this.lblStarshipName.TabIndex = 1;
            this.lblStarshipName.Text = "Name:";
            // 
            // txtStarshipName
            // 
            this.txtStarshipName.AutoSize = true;
            this.txtStarshipName.Location = new System.Drawing.Point(74, 44);
            this.txtStarshipName.Name = "txtStarshipName";
            this.txtStarshipName.Size = new System.Drawing.Size(18, 20);
            this.txtStarshipName.TabIndex = 0;
            this.txtStarshipName.Text = "...";
            // 
            // gbPilot
            // 
            this.gbPilot.Controls.Add(this.lblPilotPlanetName);
            this.gbPilot.Controls.Add(this.txtPlanetName);
            this.gbPilot.Controls.Add(this.lblPilotBirthYear);
            this.gbPilot.Controls.Add(this.txtBirthYear);
            this.gbPilot.Controls.Add(this.lblPilotName);
            this.gbPilot.Controls.Add(this.txtPilotName);
            this.gbPilot.Location = new System.Drawing.Point(392, 69);
            this.gbPilot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPilot.Name = "gbPilot";
            this.gbPilot.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPilot.Size = new System.Drawing.Size(560, 167);
            this.gbPilot.TabIndex = 1;
            this.gbPilot.TabStop = false;
            this.gbPilot.Text = "Pilot";
            // 
            // lblPilotPlanetName
            // 
            this.lblPilotPlanetName.AutoSize = true;
            this.lblPilotPlanetName.Location = new System.Drawing.Point(29, 119);
            this.lblPilotPlanetName.Name = "lblPilotPlanetName";
            this.lblPilotPlanetName.Size = new System.Drawing.Size(50, 20);
            this.lblPilotPlanetName.TabIndex = 11;
            this.lblPilotPlanetName.Text = "Planet";
            // 
            // txtPlanetName
            // 
            this.txtPlanetName.AutoSize = true;
            this.txtPlanetName.Location = new System.Drawing.Point(91, 119);
            this.txtPlanetName.Name = "txtPlanetName";
            this.txtPlanetName.Size = new System.Drawing.Size(18, 20);
            this.txtPlanetName.TabIndex = 10;
            this.txtPlanetName.Text = "...";
            // 
            // lblPilotBirthYear
            // 
            this.lblPilotBirthYear.AutoSize = true;
            this.lblPilotBirthYear.Location = new System.Drawing.Point(11, 81);
            this.lblPilotBirthYear.Name = "lblPilotBirthYear";
            this.lblPilotBirthYear.Size = new System.Drawing.Size(72, 20);
            this.lblPilotBirthYear.TabIndex = 9;
            this.lblPilotBirthYear.Text = "Birth Year";
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.AutoSize = true;
            this.txtBirthYear.Location = new System.Drawing.Point(91, 81);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(18, 20);
            this.txtBirthYear.TabIndex = 8;
            this.txtBirthYear.Text = "...";
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Location = new System.Drawing.Point(35, 44);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(52, 20);
            this.lblPilotName.TabIndex = 7;
            this.lblPilotName.Text = "Name:";
            // 
            // txtPilotName
            // 
            this.txtPilotName.AutoSize = true;
            this.txtPilotName.Location = new System.Drawing.Point(91, 44);
            this.txtPilotName.Name = "txtPilotName";
            this.txtPilotName.Size = new System.Drawing.Size(18, 20);
            this.txtPilotName.TabIndex = 6;
            this.txtPilotName.Text = "...";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(863, 30);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 31);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gbAlerts
            // 
            this.gbAlerts.Controls.Add(this.lvAlerts);
            this.gbAlerts.Location = new System.Drawing.Point(14, 287);
            this.gbAlerts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAlerts.Name = "gbAlerts";
            this.gbAlerts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAlerts.Size = new System.Drawing.Size(938, 120);
            this.gbAlerts.TabIndex = 3;
            this.gbAlerts.TabStop = false;
            this.gbAlerts.Text = "Alerts";
            // 
            // lvAlerts
            // 
            this.lvAlerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAlerts.HideSelection = false;
            this.lvAlerts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvAlerts.LabelWrap = false;
            this.lvAlerts.Location = new System.Drawing.Point(3, 24);
            this.lvAlerts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvAlerts.Name = "lvAlerts";
            this.lvAlerts.Size = new System.Drawing.Size(932, 92);
            this.lvAlerts.TabIndex = 0;
            this.lvAlerts.UseCompatibleStateImageBehavior = false;
            this.lvAlerts.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Width = 650;
            // 
            // frmRegisterInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 424);
            this.Controls.Add(this.gbAlerts);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gbPilot);
            this.Controls.Add(this.gbStarship);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegisterInOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegisterInOut_FormClosing);
            this.Load += new System.EventHandler(this.frmRegisterInOut_Load);
            this.gbStarship.ResumeLayout(false);
            this.gbStarship.PerformLayout();
            this.gbPilot.ResumeLayout(false);
            this.gbPilot.PerformLayout();
            this.gbAlerts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStarship;
        private System.Windows.Forms.Label lblStarshipClass;
        private System.Windows.Forms.Label txtStarshipClass;
        private System.Windows.Forms.Label lblStarshipModel;
        private System.Windows.Forms.Label txtStarshipModel;
        private System.Windows.Forms.Label lblStarshipName;
        private System.Windows.Forms.Label txtStarshipName;
        private System.Windows.Forms.GroupBox gbPilot;
        private System.Windows.Forms.Label lblPilotPlanetName;
        private System.Windows.Forms.Label txtPlanetName;
        private System.Windows.Forms.Label lblPilotBirthYear;
        private System.Windows.Forms.Label txtBirthYear;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.Label txtPilotName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gbAlerts;
        private System.Windows.Forms.ListView lvAlerts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}