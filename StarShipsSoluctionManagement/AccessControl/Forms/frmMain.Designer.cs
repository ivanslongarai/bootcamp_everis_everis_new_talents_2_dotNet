
namespace AccessControl.Forms
{
    partial class frmMain
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
            this.btnSynchronize = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.Location = new System.Drawing.Point(14, 16);
            this.btnSynchronize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(177, 89);
            this.btnSynchronize.TabIndex = 0;
            this.btnSynchronize.Text = "Synchronize";
            this.btnSynchronize.UseVisualStyleBackColor = true;
            this.btnSynchronize.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(213, 16);
            this.btnControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(177, 89);
            this.btnControl.TabIndex = 1;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 120);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnSynchronize);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Death Star Control System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSynchronize;
        private System.Windows.Forms.Button btnControl;
    }
}