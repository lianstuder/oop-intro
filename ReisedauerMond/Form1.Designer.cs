
namespace ReisedauerMond
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selDays = new System.Windows.Forms.RadioButton();
            this.selHours = new System.Windows.Forms.RadioButton();
            this.inputSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(162, 100);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.Text = "Berechne";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dauer";
            // 
            // selDays
            // 
            this.selDays.AutoSize = true;
            this.selDays.Location = new System.Drawing.Point(9, 19);
            this.selDays.Name = "selDays";
            this.selDays.Size = new System.Drawing.Size(68, 17);
            this.selDays.TabIndex = 2;
            this.selDays.TabStop = true;
            this.selDays.Text = "In Tagen";
            this.selDays.UseVisualStyleBackColor = true;
            // 
            // selHours
            // 
            this.selHours.AutoSize = true;
            this.selHours.Location = new System.Drawing.Point(83, 19);
            this.selHours.Name = "selHours";
            this.selHours.Size = new System.Drawing.Size(77, 17);
            this.selHours.TabIndex = 3;
            this.selHours.TabStop = true;
            this.selHours.Text = "In Stunden";
            this.selHours.UseVisualStyleBackColor = true;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(137, 43);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(58, 20);
            this.inputSpeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geschwindigkeit in Km/h";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selDays);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.selHours);
            this.groupBox1.Controls.Add(this.inputSpeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(53, 102);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(103, 20);
            this.resultBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 138);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton selDays;
        private System.Windows.Forms.RadioButton selHours;
        private System.Windows.Forms.TextBox inputSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultBox;
    }
}

