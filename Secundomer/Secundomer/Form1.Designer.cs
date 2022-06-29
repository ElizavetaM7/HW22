
namespace Secundomer
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timelabel = new System.Windows.Forms.Label();
            this.SSbutton = new System.Windows.Forms.Button();
            this.Resbutton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.BackColor = System.Drawing.Color.Transparent;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timelabel.Location = new System.Drawing.Point(94, 58);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(109, 39);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "label1";
            this.Timelabel.Click += new System.EventHandler(this.Timelabel_Click);
            // 
            // SSbutton
            // 
            this.SSbutton.BackColor = System.Drawing.Color.Transparent;
            this.SSbutton.Location = new System.Drawing.Point(40, 161);
            this.SSbutton.Name = "SSbutton";
            this.SSbutton.Size = new System.Drawing.Size(75, 23);
            this.SSbutton.TabIndex = 1;
            this.SSbutton.Text = "ПУСК";
            this.SSbutton.UseVisualStyleBackColor = true;
            // 
            // Resbutton
            // 
            this.Resbutton.BackColor = System.Drawing.Color.Transparent;
            this.Resbutton.Location = new System.Drawing.Point(195, 161);
            this.Resbutton.Name = "Resbutton";
            this.Resbutton.Size = new System.Drawing.Size(75, 23);
            this.Resbutton.TabIndex = 2;
            this.Resbutton.Text = "СБРОС";
            this.Resbutton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Secundomer.Properties.Resources.Beautiful_nature_of_Canadas_landscapes_Mark_Jinks_23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(313, 237);
            this.Controls.Add(this.Resbutton);
            this.Controls.Add(this.SSbutton);
            this.Controls.Add(this.Timelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Button SSbutton;
        private System.Windows.Forms.Button Resbutton;
        private System.Windows.Forms.Timer timer2;
        //private System.Windows.Forms.Timer timer1;
    }
}

