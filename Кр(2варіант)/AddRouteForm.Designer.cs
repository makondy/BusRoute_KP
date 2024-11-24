namespace Кр_2варіант_
{
    partial class AddRouteForm
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
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.cmbStops = new System.Windows.Forms.ComboBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.txtSeatsAvailable = new System.Windows.Forms.TextBox();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(523, 35);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRouteNumber.TabIndex = 0;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(523, 70);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 1;
            // 
            // cmbStops
            // 
            this.cmbStops.FormattingEnabled = true;
            this.cmbStops.Location = new System.Drawing.Point(523, 107);
            this.cmbStops.Name = "cmbStops";
            this.cmbStops.Size = new System.Drawing.Size(121, 21);
            this.cmbStops.TabIndex = 2;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(523, 147);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureTime.TabIndex = 3;
            // 
            // txtSeatsAvailable
            // 
            this.txtSeatsAvailable.Location = new System.Drawing.Point(523, 179);
            this.txtSeatsAvailable.Name = "txtSeatsAvailable";
            this.txtSeatsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtSeatsAvailable.TabIndex = 4;
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(523, 225);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(68, 17);
            this.rbExpress.TabIndex = 5;
            this.rbExpress.TabStop = true;
            this.rbExpress.Text = "Експрес";
            this.rbExpress.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(523, 260);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(72, 17);
            this.rbLocal.TabIndex = 6;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Місцевий";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(611, 367);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(396, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.rbExpress);
            this.Controls.Add(this.txtSeatsAvailable);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.cmbStops);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtRouteNumber);
            this.Name = "AddRouteForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.ComboBox cmbStops;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.TextBox txtSeatsAvailable;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}