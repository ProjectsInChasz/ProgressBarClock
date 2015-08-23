namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.MINUTES = new System.Windows.Forms.ProgressBar();
            this.HOURS = new System.Windows.Forms.ProgressBar();
            this.SECONDS = new System.Windows.Forms.ProgressBar();
            this.MILISECONDS = new System.Windows.Forms.ProgressBar();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.hprzyp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tydzien = new System.Windows.Forms.Label();
            this.dzien = new System.Windows.Forms.Label();
            this.miesiac = new System.Windows.Forms.Label();
            this.rok = new System.Windows.Forms.Label();
            this.YEARS = new System.Windows.Forms.ProgressBar();
            this.MONTHS = new System.Windows.Forms.ProgressBar();
            this.DAYS = new System.Windows.Forms.ProgressBar();
            this.WEEKS = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MINUTES
            // 
            this.MINUTES.Location = new System.Drawing.Point(45, 111);
            this.MINUTES.Maximum = 59;
            this.MINUTES.Name = "MINUTES";
            this.MINUTES.Size = new System.Drawing.Size(208, 34);
            this.MINUTES.Step = 1;
            this.MINUTES.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MINUTES.TabIndex = 1;
            // 
            // HOURS
            // 
            this.HOURS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HOURS.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HOURS.Location = new System.Drawing.Point(45, 71);
            this.HOURS.Maximum = 23;
            this.HOURS.Name = "HOURS";
            this.HOURS.Size = new System.Drawing.Size(208, 34);
            this.HOURS.Step = 1;
            this.HOURS.TabIndex = 2;
            // 
            // SECONDS
            // 
            this.SECONDS.Location = new System.Drawing.Point(45, 151);
            this.SECONDS.Maximum = 59;
            this.SECONDS.Name = "SECONDS";
            this.SECONDS.Size = new System.Drawing.Size(208, 34);
            this.SECONDS.Step = 1;
            this.SECONDS.TabIndex = 3;
            // 
            // MILISECONDS
            // 
            this.MILISECONDS.Location = new System.Drawing.Point(45, 191);
            this.MILISECONDS.MarqueeAnimationSpeed = 10;
            this.MILISECONDS.Maximum = 999;
            this.MILISECONDS.Name = "MILISECONDS";
            this.MILISECONDS.Size = new System.Drawing.Size(208, 34);
            this.MILISECONDS.Step = 100;
            this.MILISECONDS.TabIndex = 4;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // hprzyp
            // 
            this.hprzyp.AutoSize = true;
            this.hprzyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hprzyp.Location = new System.Drawing.Point(102, 19);
            this.hprzyp.Name = "hprzyp";
            this.hprzyp.Size = new System.Drawing.Size(115, 31);
            this.hprzyp.TabIndex = 12;
            this.hprzyp.Text = "Godzina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "hh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ss";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(125, 197);
            this.textBox1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 294);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hprzyp);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.MILISECONDS);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SECONDS);
            this.tabPage1.Controls.Add(this.MINUTES);
            this.tabPage1.Controls.Add(this.HOURS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "zegar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tydzien);
            this.tabPage2.Controls.Add(this.dzien);
            this.tabPage2.Controls.Add(this.miesiac);
            this.tabPage2.Controls.Add(this.rok);
            this.tabPage2.Controls.Add(this.YEARS);
            this.tabPage2.Controls.Add(this.MONTHS);
            this.tabPage2.Controls.Add(this.DAYS);
            this.tabPage2.Controls.Add(this.WEEKS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tydzien
            // 
            this.tydzien.AutoSize = true;
            this.tydzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tydzien.Location = new System.Drawing.Point(150, 166);
            this.tydzien.Name = "tydzien";
            this.tydzien.Size = new System.Drawing.Size(59, 20);
            this.tydzien.TabIndex = 7;
            this.tydzien.Text = "tydzien";
            // 
            // dzien
            // 
            this.dzien.AutoSize = true;
            this.dzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzien.Location = new System.Drawing.Point(150, 218);
            this.dzien.Name = "dzien";
            this.dzien.Size = new System.Drawing.Size(34, 20);
            this.dzien.TabIndex = 6;
            this.dzien.Text = "day";
            // 
            // miesiac
            // 
            this.miesiac.AutoSize = true;
            this.miesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miesiac.Location = new System.Drawing.Point(150, 114);
            this.miesiac.Name = "miesiac";
            this.miesiac.Size = new System.Drawing.Size(42, 20);
            this.miesiac.TabIndex = 5;
            this.miesiac.Text = "mies";
            // 
            // rok
            // 
            this.rok.AutoSize = true;
            this.rok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rok.Location = new System.Drawing.Point(150, 62);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(21, 20);
            this.rok.TabIndex = 4;
            this.rok.Text = "yr";
            // 
            // YEARS
            // 
            this.YEARS.Location = new System.Drawing.Point(29, 62);
            this.YEARS.Maximum = 2020;
            this.YEARS.Name = "YEARS";
            this.YEARS.Size = new System.Drawing.Size(276, 39);
            this.YEARS.TabIndex = 3;
            // 
            // MONTHS
            // 
            this.MONTHS.Location = new System.Drawing.Point(31, 111);
            this.MONTHS.Maximum = 12;
            this.MONTHS.Minimum = 1;
            this.MONTHS.Name = "MONTHS";
            this.MONTHS.Size = new System.Drawing.Size(274, 39);
            this.MONTHS.TabIndex = 2;
            this.MONTHS.Value = 1;
            // 
            // DAYS
            // 
            this.DAYS.Location = new System.Drawing.Point(29, 209);
            this.DAYS.Maximum = 31;
            this.DAYS.Minimum = 1;
            this.DAYS.Name = "DAYS";
            this.DAYS.Size = new System.Drawing.Size(274, 39);
            this.DAYS.TabIndex = 1;
            this.DAYS.Value = 1;
            // 
            // WEEKS
            // 
            this.WEEKS.Location = new System.Drawing.Point(29, 160);
            this.WEEKS.Maximum = 2012;
            this.WEEKS.Name = "WEEKS";
            this.WEEKS.Size = new System.Drawing.Size(274, 39);
            this.WEEKS.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar MINUTES;
        private System.Windows.Forms.ProgressBar HOURS;
        private System.Windows.Forms.ProgressBar SECONDS;
        private System.Windows.Forms.ProgressBar MILISECONDS;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label hprzyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar YEARS;
        private System.Windows.Forms.ProgressBar MONTHS;
        private System.Windows.Forms.ProgressBar DAYS;
        private System.Windows.Forms.ProgressBar WEEKS;
        private System.Windows.Forms.Label rok;
        private System.Windows.Forms.Label miesiac;
        private System.Windows.Forms.Label tydzien;
        private System.Windows.Forms.Label dzien;

    }
}

