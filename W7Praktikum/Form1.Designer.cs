
namespace W7Praktikum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMasukkanInput = new System.Windows.Forms.Label();
            this.labelMasukkanHuruf = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.txtBoxInputHuruf = new System.Windows.Forms.TextBox();
            this.txtBoxMenjadi = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMasukkanInput
            // 
            this.labelMasukkanInput.AutoSize = true;
            this.labelMasukkanInput.Location = new System.Drawing.Point(56, 57);
            this.labelMasukkanInput.Name = "labelMasukkanInput";
            this.labelMasukkanInput.Size = new System.Drawing.Size(133, 20);
            this.labelMasukkanInput.TabIndex = 0;
            this.labelMasukkanInput.Text = "Masukkan Kalimat ";
            // 
            // labelMasukkanHuruf
            // 
            this.labelMasukkanHuruf.AutoSize = true;
            this.labelMasukkanHuruf.Location = new System.Drawing.Point(57, 110);
            this.labelMasukkanHuruf.Name = "labelMasukkanHuruf";
            this.labelMasukkanHuruf.Size = new System.Drawing.Size(115, 20);
            this.labelMasukkanHuruf.TabIndex = 1;
            this.labelMasukkanHuruf.Text = "Masukkan Huruf";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(66, 224);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(49, 20);
            this.labelHasil.TabIndex = 2;
            this.labelHasil.Text = "Hasil :";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(195, 224);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 20);
            this.labelOutput.TabIndex = 3;
            // 
            // txtBoxInputKalimat
            // 
            this.txtBoxInputKalimat.Location = new System.Drawing.Point(195, 57);
            this.txtBoxInputKalimat.Name = "txtBoxInputKalimat";
            this.txtBoxInputKalimat.Size = new System.Drawing.Size(310, 27);
            this.txtBoxInputKalimat.TabIndex = 4;
            // 
            // txtBoxInputHuruf
            // 
            this.txtBoxInputHuruf.Location = new System.Drawing.Point(195, 110);
            this.txtBoxInputHuruf.Name = "txtBoxInputHuruf";
            this.txtBoxInputHuruf.Size = new System.Drawing.Size(102, 27);
            this.txtBoxInputHuruf.TabIndex = 5;
            // 
            // txtBoxMenjadi
            // 
            this.txtBoxMenjadi.Location = new System.Drawing.Point(403, 110);
            this.txtBoxMenjadi.Name = "txtBoxMenjadi";
            this.txtBoxMenjadi.Size = new System.Drawing.Size(102, 27);
            this.txtBoxMenjadi.TabIndex = 6;
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(334, 113);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(63, 20);
            this.labelMenjadi.TabIndex = 7;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(195, 162);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(310, 29);
            this.buttonKonversi.TabIndex = 8;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 358);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.txtBoxMenjadi);
            this.Controls.Add(this.txtBoxInputHuruf);
            this.Controls.Add(this.txtBoxInputKalimat);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelMasukkanHuruf);
            this.Controls.Add(this.labelMasukkanInput);
            this.Name = "Form1";
            this.Text = "Pembuat Quiz Panda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMasukkanInput;
        private System.Windows.Forms.Label labelMasukkanHuruf;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtBoxInputKalimat;
        private System.Windows.Forms.TextBox txtBoxInputHuruf;
        private System.Windows.Forms.TextBox txtBoxMenjadi;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
    }
}

