
namespace DateTimePicker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite datum leta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite vrijeme polaska:";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(44, 114);
            this.txtIspis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.ReadOnly = true;
            this.txtIspis.Size = new System.Drawing.Size(572, 258);
            this.txtIspis.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(259, 25);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(265, 22);
            this.dtpDatum.TabIndex = 3;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(259, 63);
            this.dtpVrijeme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(265, 22);
            this.dtpVrijeme.TabIndex = 4;
            this.dtpVrijeme.Value = new System.DateTime(2022, 1, 18, 11, 58, 0, 0);
            this.dtpVrijeme.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(259, 380);
            this.btnRezervacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(139, 28);
            this.btnRezervacija.TabIndex = 5;
            this.btnRezervacija.Text = "Rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 423);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Upotreba DateTimePicker kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Button btnRezervacija;
    }
}

