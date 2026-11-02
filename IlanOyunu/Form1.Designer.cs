namespace IlanOyunu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOyun = new System.Windows.Forms.Panel();
            this.panelKontrol = new System.Windows.Forms.Panel();
            this.lblXalYazi = new System.Windows.Forms.Label();
            this.lblXal = new System.Windows.Forms.Label();
            this.btnYuxari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSola = new System.Windows.Forms.Button();
            this.btnSaga = new System.Windows.Forms.Button();
            this.btnCixis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelKontrol.SuspendLayout();
            this.SuspendLayout();
            //
            // panelOyun
            //
            this.panelOyun.BackColor = System.Drawing.Color.White;
            this.panelOyun.Location = new System.Drawing.Point(0, 0);
            this.panelOyun.Name = "panelOyun";
            this.panelOyun.Size = new System.Drawing.Size(630, 340);
            this.panelOyun.TabIndex = 0;
            //
            // panelKontrol
            //
            this.panelKontrol.BackColor = System.Drawing.Color.Gray;
            this.panelKontrol.Controls.Add(this.lblXalYazi);
            this.panelKontrol.Controls.Add(this.lblXal);
            this.panelKontrol.Controls.Add(this.btnYuxari);
            this.panelKontrol.Controls.Add(this.btnAsagi);
            this.panelKontrol.Controls.Add(this.btnSola);
            this.panelKontrol.Controls.Add(this.btnSaga);
            this.panelKontrol.Controls.Add(this.btnCixis);
            this.panelKontrol.Location = new System.Drawing.Point(0, 340);
            this.panelKontrol.Name = "panelKontrol";
            this.panelKontrol.Size = new System.Drawing.Size(630, 220);
            this.panelKontrol.TabIndex = 1;
            //
            // lblXalYazi
            //
            this.lblXalYazi.AutoSize = true;
            this.lblXalYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblXalYazi.ForeColor = System.Drawing.Color.White;
            this.lblXalYazi.Location = new System.Drawing.Point(30, 70);
            this.lblXalYazi.Name = "lblXalYazi";
            this.lblXalYazi.Size = new System.Drawing.Size(42, 18);
            this.lblXalYazi.TabIndex = 0;
            this.lblXalYazi.Text = "Xal:";
            //
            // lblXal
            //
            this.lblXal.AutoSize = true;
            this.lblXal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblXal.ForeColor = System.Drawing.Color.White;
            this.lblXal.Location = new System.Drawing.Point(95, 70);
            this.lblXal.Name = "lblXal";
            this.lblXal.Size = new System.Drawing.Size(18, 18);
            this.lblXal.TabIndex = 1;
            this.lblXal.Text = "0";
            //
            // btnYuxari
            //
            this.btnYuxari.BackColor = System.Drawing.Color.SteelBlue;
            this.btnYuxari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYuxari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnYuxari.ForeColor = System.Drawing.Color.White;
            this.btnYuxari.Location = new System.Drawing.Point(290, 10);
            this.btnYuxari.Name = "btnYuxari";
            this.btnYuxari.Size = new System.Drawing.Size(55, 55);
            this.btnYuxari.TabIndex = 2;
            this.btnYuxari.TabStop = false;
            this.btnYuxari.Text = "↑";
            this.btnYuxari.UseVisualStyleBackColor = false;
            this.btnYuxari.Click += new System.EventHandler(this.btnYuxari_Click);
            //
            // btnAsagi
            //
            this.btnAsagi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAsagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnAsagi.ForeColor = System.Drawing.Color.White;
            this.btnAsagi.Location = new System.Drawing.Point(290, 150);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(55, 55);
            this.btnAsagi.TabIndex = 3;
            this.btnAsagi.TabStop = false;
            this.btnAsagi.Text = "↓";
            this.btnAsagi.UseVisualStyleBackColor = false;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            //
            // btnSola
            //
            this.btnSola.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSola.ForeColor = System.Drawing.Color.White;
            this.btnSola.Location = new System.Drawing.Point(220, 80);
            this.btnSola.Name = "btnSola";
            this.btnSola.Size = new System.Drawing.Size(55, 55);
            this.btnSola.TabIndex = 4;
            this.btnSola.TabStop = false;
            this.btnSola.Text = "←";
            this.btnSola.UseVisualStyleBackColor = false;
            this.btnSola.Click += new System.EventHandler(this.btnSola_Click);
            //
            // btnSaga
            //
            this.btnSaga.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSaga.ForeColor = System.Drawing.Color.White;
            this.btnSaga.Location = new System.Drawing.Point(360, 80);
            this.btnSaga.Name = "btnSaga";
            this.btnSaga.Size = new System.Drawing.Size(55, 55);
            this.btnSaga.TabIndex = 5;
            this.btnSaga.TabStop = false;
            this.btnSaga.Text = "→";
            this.btnSaga.UseVisualStyleBackColor = false;
            this.btnSaga.Click += new System.EventHandler(this.btnSaga_Click);
            //
            // btnCixis
            //
            this.btnCixis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCixis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCixis.ForeColor = System.Drawing.Color.White;
            this.btnCixis.Location = new System.Drawing.Point(500, 170);
            this.btnCixis.Name = "btnCixis";
            this.btnCixis.Size = new System.Drawing.Size(110, 35);
            this.btnCixis.TabIndex = 6;
            this.btnCixis.TabStop = false;
            this.btnCixis.Text = "Çıxış";
            this.btnCixis.UseVisualStyleBackColor = true;
            this.btnCixis.Click += new System.EventHandler(this.btnCixis_Click);
            //
            // timer1
            //
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 560);
            this.Controls.Add(this.panelKontrol);
            this.Controls.Add(this.panelOyun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelKontrol.ResumeLayout(false);
            this.panelKontrol.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelOyun;
        private System.Windows.Forms.Panel panelKontrol;
        private System.Windows.Forms.Label lblXalYazi;
        private System.Windows.Forms.Label lblXal;
        private System.Windows.Forms.Button btnYuxari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSola;
        private System.Windows.Forms.Button btnSaga;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.Timer timer1;
    }
}
