namespace MorseCodeEncryption
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
            this.txbEnglish = new System.Windows.Forms.TextBox();
            this.txbMorseCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRevert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEnglish
            // 
            this.txbEnglish.AcceptsReturn = true;
            this.txbEnglish.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbEnglish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEnglish.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnglish.Location = new System.Drawing.Point(4, 118);
            this.txbEnglish.Multiline = true;
            this.txbEnglish.Name = "txbEnglish";
            this.txbEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbEnglish.Size = new System.Drawing.Size(348, 279);
            this.txbEnglish.TabIndex = 0;
            // 
            // txbMorseCode
            // 
            this.txbMorseCode.AcceptsReturn = true;
            this.txbMorseCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbMorseCode.Font = new System.Drawing.Font("Candara", 12F);
            this.txbMorseCode.Location = new System.Drawing.Point(452, 118);
            this.txbMorseCode.Multiline = true;
            this.txbMorseCode.Name = "txbMorseCode";
            this.txbMorseCode.ReadOnly = true;
            this.txbMorseCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMorseCode.Size = new System.Drawing.Size(348, 279);
            this.txbMorseCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morse Code";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(-10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 84);
            this.label3.TabIndex = 4;
            this.label3.Text = "Morse Code Encrytion";
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.btnConvert.Location = new System.Drawing.Point(4, 403);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 35);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(223, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(447, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Programmer: Saeed Lahmdi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRevert
            // 
            this.btnRevert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRevert.Font = new System.Drawing.Font("Lucida Console", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevert.Location = new System.Drawing.Point(358, 249);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(88, 35);
            this.btnRevert.TabIndex = 8;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMorseCode);
            this.Controls.Add(this.txbEnglish);
            this.Name = "Form1";
            this.Text = "Morse Code Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbMorseCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.TextBox txbEnglish;
    }
}

