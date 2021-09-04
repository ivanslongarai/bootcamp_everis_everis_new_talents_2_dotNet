
namespace AccessControl.Forms
{
    partial class frmStarshipControl
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
            this.txtStarship = new System.Windows.Forms.TextBox();
            this.lbStarship = new System.Windows.Forms.Label();
            this.lbPilot = new System.Windows.Forms.Label();
            this.txtPilot = new System.Windows.Forms.TextBox();
            this.dgvStarship = new System.Windows.Forms.DataGridView();
            this.dgvPilots = new System.Windows.Forms.DataGridView();
            this.gbArriveDeparture = new System.Windows.Forms.GroupBox();
            this.rdbDeparturing = new System.Windows.Forms.RadioButton();
            this.rdbArriving = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGetStarship = new System.Windows.Forms.Button();
            this.btnGetPilot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStarship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilots)).BeginInit();
            this.gbArriveDeparture.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStarship
            // 
            this.txtStarship.Location = new System.Drawing.Point(80, 16);
            this.txtStarship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStarship.Name = "txtStarship";
            this.txtStarship.Size = new System.Drawing.Size(658, 27);
            this.txtStarship.TabIndex = 0;
            // 
            // lbStarship
            // 
            this.lbStarship.AutoSize = true;
            this.lbStarship.Location = new System.Drawing.Point(12, 23);
            this.lbStarship.Name = "lbStarship";
            this.lbStarship.Size = new System.Drawing.Size(62, 20);
            this.lbStarship.TabIndex = 1;
            this.lbStarship.Text = "Starship";
            // 
            // lbPilot
            // 
            this.lbPilot.AutoSize = true;
            this.lbPilot.Location = new System.Drawing.Point(35, 298);
            this.lbPilot.Name = "lbPilot";
            this.lbPilot.Size = new System.Drawing.Size(39, 20);
            this.lbPilot.TabIndex = 3;
            this.lbPilot.Text = "Pilot";
            // 
            // txtPilot
            // 
            this.txtPilot.Location = new System.Drawing.Point(80, 291);
            this.txtPilot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPilot.Name = "txtPilot";
            this.txtPilot.Size = new System.Drawing.Size(658, 27);
            this.txtPilot.TabIndex = 2;
            // 
            // dgvStarship
            // 
            this.dgvStarship.AllowUserToAddRows = false;
            this.dgvStarship.AllowUserToDeleteRows = false;
            this.dgvStarship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStarship.Location = new System.Drawing.Point(80, 55);
            this.dgvStarship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStarship.Name = "dgvStarship";
            this.dgvStarship.RowHeadersWidth = 51;
            this.dgvStarship.RowTemplate.Height = 25;
            this.dgvStarship.Size = new System.Drawing.Size(776, 228);
            this.dgvStarship.TabIndex = 4;
            // 
            // dgvPilots
            // 
            this.dgvPilots.AllowUserToAddRows = false;
            this.dgvPilots.AllowUserToDeleteRows = false;
            this.dgvPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilots.Location = new System.Drawing.Point(80, 329);
            this.dgvPilots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPilots.Name = "dgvPilots";
            this.dgvPilots.RowHeadersWidth = 51;
            this.dgvPilots.RowTemplate.Height = 25;
            this.dgvPilots.Size = new System.Drawing.Size(776, 228);
            this.dgvPilots.TabIndex = 5;
            // 
            // gbArriveDeparture
            // 
            this.gbArriveDeparture.Controls.Add(this.rdbDeparturing);
            this.gbArriveDeparture.Controls.Add(this.rdbArriving);
            this.gbArriveDeparture.Location = new System.Drawing.Point(80, 570);
            this.gbArriveDeparture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbArriveDeparture.Name = "gbArriveDeparture";
            this.gbArriveDeparture.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbArriveDeparture.Size = new System.Drawing.Size(342, 49);
            this.gbArriveDeparture.TabIndex = 6;
            this.gbArriveDeparture.TabStop = false;
            // 
            // rdbDeparturing
            // 
            this.rdbDeparturing.AutoSize = true;
            this.rdbDeparturing.Location = new System.Drawing.Point(204, 17);
            this.rdbDeparturing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDeparturing.Name = "rdbDeparturing";
            this.rdbDeparturing.Size = new System.Drawing.Size(110, 24);
            this.rdbDeparturing.TabIndex = 1;
            this.rdbDeparturing.TabStop = true;
            this.rdbDeparturing.Text = "Departuring";
            this.rdbDeparturing.UseVisualStyleBackColor = true;
            // 
            // rdbArriving
            // 
            this.rdbArriving.AutoSize = true;
            this.rdbArriving.Location = new System.Drawing.Point(24, 16);
            this.rdbArriving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbArriving.Name = "rdbArriving";
            this.rdbArriving.Size = new System.Drawing.Size(82, 24);
            this.rdbArriving.TabIndex = 0;
            this.rdbArriving.TabStop = true;
            this.rdbArriving.Text = "Arriving";
            this.rdbArriving.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(770, 580);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 31);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGetStarship
            // 
            this.btnGetStarship.Location = new System.Drawing.Point(744, 15);
            this.btnGetStarship.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetStarship.Name = "btnGetStarship";
            this.btnGetStarship.Size = new System.Drawing.Size(112, 31);
            this.btnGetStarship.TabIndex = 8;
            this.btnGetStarship.Text = "Get Starship";
            this.btnGetStarship.UseVisualStyleBackColor = true;
            this.btnGetStarship.Click += new System.EventHandler(this.btnGetStarship_Click);
            // 
            // btnGetPilot
            // 
            this.btnGetPilot.Location = new System.Drawing.Point(744, 289);
            this.btnGetPilot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetPilot.Name = "btnGetPilot";
            this.btnGetPilot.Size = new System.Drawing.Size(112, 31);
            this.btnGetPilot.TabIndex = 9;
            this.btnGetPilot.Text = "Get Pilot";
            this.btnGetPilot.UseVisualStyleBackColor = true;
            this.btnGetPilot.Click += new System.EventHandler(this.btnGetPilot_Click);
            // 
            // frmStarshipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 632);
            this.Controls.Add(this.btnGetPilot);
            this.Controls.Add(this.btnGetStarship);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbArriveDeparture);
            this.Controls.Add(this.dgvPilots);
            this.Controls.Add(this.dgvStarship);
            this.Controls.Add(this.lbPilot);
            this.Controls.Add(this.txtPilot);
            this.Controls.Add(this.lbStarship);
            this.Controls.Add(this.txtStarship);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStarshipControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStarshipControl_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStarship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilots)).EndInit();
            this.gbArriveDeparture.ResumeLayout(false);
            this.gbArriveDeparture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStarship;
        private System.Windows.Forms.Label lbStarship;
        private System.Windows.Forms.Label lbPilot;
        private System.Windows.Forms.TextBox txtPilot;
        private System.Windows.Forms.DataGridView dgvStarship;
        private System.Windows.Forms.DataGridView dgvPilots;
        private System.Windows.Forms.GroupBox gbArriveDeparture;
        private System.Windows.Forms.RadioButton rdbDeparturing;
        private System.Windows.Forms.RadioButton rdbArriving;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGetStarship;
        private System.Windows.Forms.Button btnGetPilot;
    }
}