namespace Vormen
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
            this.btnMaken = new System.Windows.Forms.Button();
            this.txtStraal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBord = new System.Windows.Forms.PictureBox();
            this.listCirkels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaken
            // 
            this.btnMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaken.Location = new System.Drawing.Point(78, 117);
            this.btnMaken.Name = "btnMaken";
            this.btnMaken.Size = new System.Drawing.Size(168, 49);
            this.btnMaken.TabIndex = 0;
            this.btnMaken.Text = "Maken";
            this.btnMaken.UseVisualStyleBackColor = true;
            this.btnMaken.Click += new System.EventHandler(this.BtnMaken_Click);
            // 
            // txtStraal
            // 
            this.txtStraal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStraal.Location = new System.Drawing.Point(164, 48);
            this.txtStraal.Name = "txtStraal";
            this.txtStraal.Size = new System.Drawing.Size(82, 31);
            this.txtStraal.TabIndex = 1;
            this.txtStraal.TextChanged += new System.EventHandler(this.TxtStraal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Straal:";
            // 
            // picBord
            // 
            this.picBord.Location = new System.Drawing.Point(275, 48);
            this.picBord.Name = "picBord";
            this.picBord.Size = new System.Drawing.Size(413, 343);
            this.picBord.TabIndex = 3;
            this.picBord.TabStop = false;
            this.picBord.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBord_Paint);
            // 
            // listCirkels
            // 
            this.listCirkels.FormattingEnabled = true;
            this.listCirkels.Location = new System.Drawing.Point(80, 203);
            this.listCirkels.Name = "listCirkels";
            this.listCirkels.Size = new System.Drawing.Size(165, 186);
            this.listCirkels.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 417);
            this.Controls.Add(this.listCirkels);
            this.Controls.Add(this.picBord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStraal);
            this.Controls.Add(this.btnMaken);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaken;
        private System.Windows.Forms.TextBox txtStraal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBord;
        private System.Windows.Forms.ListBox listCirkels;
    }
}

