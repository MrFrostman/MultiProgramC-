namespace Actividad5New
{
    partial class Grados
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Farenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Celsius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Farenheit";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(273, 333);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(128, 22);
            this.txt4.TabIndex = 15;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(273, 125);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(128, 22);
            this.txt2.TabIndex = 14;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(50, 333);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(128, 22);
            this.txt3.TabIndex = 13;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(50, 125);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(128, 22);
            this.Txt1.TabIndex = 12;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(497, 96);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(253, 259);
            this.Btn1.TabIndex = 10;
            this.Btn1.Text = "Convertir";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Grados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Btn1);
            this.Name = "Grados";
            this.Text = "Grados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Button Btn1;
    }
}