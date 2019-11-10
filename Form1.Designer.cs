namespace KnapsackProblem
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
            this.findFileButton = new System.Windows.Forms.Button();
            this.defaultFileButton = new System.Windows.Forms.Button();
            this.hillClimbingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findFileButton
            // 
            this.findFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.findFileButton.Location = new System.Drawing.Point(632, 12);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(75, 23);
            this.findFileButton.TabIndex = 0;
            this.findFileButton.Text = "Find File";
            this.findFileButton.UseVisualStyleBackColor = false;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // defaultFileButton
            // 
            this.defaultFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.defaultFileButton.Location = new System.Drawing.Point(713, 12);
            this.defaultFileButton.Name = "defaultFileButton";
            this.defaultFileButton.Size = new System.Drawing.Size(75, 23);
            this.defaultFileButton.TabIndex = 1;
            this.defaultFileButton.Text = "Default File";
            this.defaultFileButton.UseVisualStyleBackColor = false;
            this.defaultFileButton.Click += new System.EventHandler(this.defaultFileButton_Click);
            // 
            // hillClimbingButton
            // 
            this.hillClimbingButton.Location = new System.Drawing.Point(12, 45);
            this.hillClimbingButton.Name = "hillClimbingButton";
            this.hillClimbingButton.Size = new System.Drawing.Size(75, 23);
            this.hillClimbingButton.TabIndex = 2;
            this.hillClimbingButton.Text = "HillClimbing";
            this.hillClimbingButton.UseVisualStyleBackColor = true;
            this.hillClimbingButton.Click += new System.EventHandler(this.hillClimbingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hillClimbingButton);
            this.Controls.Add(this.defaultFileButton);
            this.Controls.Add(this.findFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.Button defaultFileButton;
        private System.Windows.Forms.Button hillClimbingButton;
    }
}

