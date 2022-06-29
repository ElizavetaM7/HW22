using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20062022
{
    public partial class secundomer : Form
    {
        public int min, sec, ms;
        public secundomer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Label();
            this.buttonSS = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer.Location = new System.Drawing.Point(96, 70);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(86, 31);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "label1";
            // 
            // buttonSS
            // 
            this.buttonSS.Location = new System.Drawing.Point(42, 164);
            this.buttonSS.Name = "buttonSS";
            this.buttonSS.Size = new System.Drawing.Size(75, 23);
            this.buttonSS.TabIndex = 1;
            this.buttonSS.Text = "button1";
            this.buttonSS.UseVisualStyleBackColor = true;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(175, 164);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 23);
            this.buttonRes.TabIndex = 2;
            this.buttonRes.Text = "button2";
            this.buttonRes.UseVisualStyleBackColor = true;
            // 
            // secundomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 226);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonSS);
            this.Controls.Add(this.Timer);
            this.Name = "secundomer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1(object sender, EventArgs e)
        {
            ms += 1;
            if(ms==10)
            {
                ms = 0;
                sec += 1;
            }
            if(sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
                min = 0;
        }
        void StartStop()
        {
            Timer.Enabled = true;
            buttonSS.Text = "ПУСК";
            if(Timer.Enabled)
            {

            }
        }

        private Label Timer;
        private Button buttonSS;
        private Button buttonRes;
        private Timer timer2;
        private IContainer components;
    }
}
