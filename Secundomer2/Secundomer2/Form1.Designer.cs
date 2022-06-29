
namespace Secundomer2
{
    partial class Secundomer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitalizeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Label();
            this.SSbutton = new System.Windows.Forms.Button();
            this.Resbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            this.SSbutton.BackColor = System.Drawing.Color.Transparent;
            this.SSbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SSbutton.FlatAppearance.BorderSize = 0;
            this.SSbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSbutton.Location = new System.Drawing.Point(120, 300);
            this.SSbutton.Name = "SSbutton";
            this.SSbutton.TabIndex = 0;
            this.SSbutton.Size = new System.Drawing.Size(115, 35);
            this.SSbutton.Text = "Пуск";
            this.SSbutton.UseVisualStyleBackColor = false;
            this.SSbutton.Click += new System.EventHandler(this.buttonSS_Click);

            this.Resbutton.BackColor = System.Drawing.Color.Transparent;
            this.Resbutton.FlatAppearance.BorderSize = 0;
            this.Resbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resbutton.Location = new System.Drawing.Point(120, 320);
            this.Resbutton.Name = "Resbutton";
            this.Resbutton.Size = new System.Drawing.Size(115, 35);
            this.Resbutton.TabIndex = 1;
            this.Resbutton.Text = "Сброс";
            this.Resbutton.UseVisualStyleBackColor = false;
            this.Resbutton.Click += new System.EventHandler(this.Resert_Click);

            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.Location = new System.Drawing.Point(65, 65);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(200, 80);
            this.Timer.TabIndex = 1;

            //this.timer1.Tick += System.EventHandler(this.Secundomer_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.SSbutton);
            this.Controls.Add(this.Resbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Secundomer";
            this.Text = "Секундомер";
            this.Load += new System.EventHandler(this.Secundomer_Load);
            this.ResumeLayout(false);

        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Label();
            this.SSbutton = new System.Windows.Forms.Button();
            this.Resbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer.Location = new System.Drawing.Point(108, 62);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(147, 54);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "label1";
            // 
            // SSbutton
            // 
            this.SSbutton.Location = new System.Drawing.Point(48, 159);
            this.SSbutton.Name = "SSbutton";
            this.SSbutton.Size = new System.Drawing.Size(75, 23);
            this.SSbutton.TabIndex = 1;
            this.SSbutton.Text = "button1";
            this.SSbutton.UseVisualStyleBackColor = true;
            // 
            // Resbutton
            // 
            this.Resbutton.Location = new System.Drawing.Point(237, 159);
            this.Resbutton.Name = "Resbutton";
            this.Resbutton.Size = new System.Drawing.Size(75, 23);
            this.Resbutton.TabIndex = 2;
            this.Resbutton.Text = "button2";
            this.Resbutton.UseVisualStyleBackColor = true;
            // 
            // Secundomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Secundomer2.Properties.Resources.Beautiful_nature_of_Canadas_landscapes_Mark_Jinks_23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(367, 258);
            this.Controls.Add(this.Resbutton);
            this.Controls.Add(this.SSbutton);
            this.Controls.Add(this.Timer);
            this.Name = "Secundomer";
            this.Text = "Секундомер";
            this.Load += new System.EventHandler(this.Secundomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Button SSbutton;
        private System.Windows.Forms.Button Resbutton;
        private System.Windows.Forms.Timer timer1;
    }
}

