
namespace Calculator
{
    partial class MainForm
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
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.oplabel = new System.Windows.Forms.Label();
            this.EQlabel = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XtextBox
            // 
            this.XtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XtextBox.Location = new System.Drawing.Point(13, 24);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(109, 26);
            this.XtextBox.TabIndex = 1;
            // 
            // YtextBox
            // 
            this.YtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YtextBox.Location = new System.Drawing.Point(169, 24);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(109, 26);
            this.YtextBox.TabIndex = 2;
            // 
            // oplabel
            // 
            this.oplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oplabel.Location = new System.Drawing.Point(128, 24);
            this.oplabel.Name = "oplabel";
            this.oplabel.Size = new System.Drawing.Size(35, 23);
            this.oplabel.TabIndex = 3;
            // 
            // EQlabel
            // 
            this.EQlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EQlabel.Location = new System.Drawing.Point(295, 24);
            this.EQlabel.Name = "EQlabel";
            this.EQlabel.Size = new System.Drawing.Size(24, 23);
            this.EQlabel.TabIndex = 3;
            this.EQlabel.Text = "=";
            // 
            // Resultlabel
            // 
            this.Resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resultlabel.Location = new System.Drawing.Point(325, 27);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(110, 23);
            this.Resultlabel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 96);
            this.Controls.Add(this.EQlabel);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.oplabel);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Name = "MainForm";
            this.Text = "Целочисленный калькулятор";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.Label oplabel;
        private System.Windows.Forms.Label EQlabel;
        private System.Windows.Forms.Label Resultlabel;
    }
}

