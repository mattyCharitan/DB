namespace ClinicManager
{
    partial class Form1
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
            this.GetAllPatientsBtn = new System.Windows.Forms.Button();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.UpdatePatientBtn = new System.Windows.Forms.Button();
            this.RemovePatientBtn = new System.Windows.Forms.Button();
            this.NewGetAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetAllPatientsBtn
            // 
            this.GetAllPatientsBtn.Location = new System.Drawing.Point(37, 47);
            this.GetAllPatientsBtn.Name = "GetAllPatientsBtn";
            this.GetAllPatientsBtn.Size = new System.Drawing.Size(112, 34);
            this.GetAllPatientsBtn.TabIndex = 0;
            this.GetAllPatientsBtn.Text = "Get All";
            this.GetAllPatientsBtn.UseVisualStyleBackColor = true;
            this.GetAllPatientsBtn.Click += new System.EventHandler(this.GetAllPatientsBtn_Click);
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(37, 97);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(112, 34);
            this.AddPatientBtn.TabIndex = 0;
            this.AddPatientBtn.Text = "Add";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // UpdatePatientBtn
            // 
            this.UpdatePatientBtn.Location = new System.Drawing.Point(37, 150);
            this.UpdatePatientBtn.Name = "UpdatePatientBtn";
            this.UpdatePatientBtn.Size = new System.Drawing.Size(112, 34);
            this.UpdatePatientBtn.TabIndex = 0;
            this.UpdatePatientBtn.Text = "Update";
            this.UpdatePatientBtn.UseVisualStyleBackColor = true;
            this.UpdatePatientBtn.Click += new System.EventHandler(this.UpdatePatientBtn_Click);
            // 
            // RemovePatientBtn
            // 
            this.RemovePatientBtn.Location = new System.Drawing.Point(37, 203);
            this.RemovePatientBtn.Name = "RemovePatientBtn";
            this.RemovePatientBtn.Size = new System.Drawing.Size(112, 34);
            this.RemovePatientBtn.TabIndex = 0;
            this.RemovePatientBtn.Text = "Remove";
            this.RemovePatientBtn.UseVisualStyleBackColor = true;
            this.RemovePatientBtn.Click += new System.EventHandler(this.RemovePatientBtn_Click);
            // 
            // NewGetAllBtn
            // 
            this.NewGetAllBtn.Location = new System.Drawing.Point(37, 263);
            this.NewGetAllBtn.Name = "NewGetAllBtn";
            this.NewGetAllBtn.Size = new System.Drawing.Size(112, 34);
            this.NewGetAllBtn.TabIndex = 1;
            this.NewGetAllBtn.Text = "New All";
            this.NewGetAllBtn.UseVisualStyleBackColor = true;
            this.NewGetAllBtn.Click += new System.EventHandler(this.NewGetAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewGetAllBtn);
            this.Controls.Add(this.RemovePatientBtn);
            this.Controls.Add(this.UpdatePatientBtn);
            this.Controls.Add(this.AddPatientBtn);
            this.Controls.Add(this.GetAllPatientsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button GetAllPatientsBtn;
        private Button AddPatientBtn;
        private Button UpdatePatientBtn;
        private Button RemovePatientBtn;
        private Button NewGetAllBtn;
    }
}