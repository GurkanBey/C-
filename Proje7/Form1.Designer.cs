namespace Proje7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelno = new System.Windows.Forms.Label();
            this.labelDogru = new System.Windows.Forms.Label();
            this.labelyanlis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(13, 134);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(75, 44);
            this.btna.TabIndex = 1;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(94, 134);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(75, 44);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(175, 134);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 44);
            this.btnc.TabIndex = 4;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(256, 134);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(75, 44);
            this.btnd.TabIndex = 3;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dogru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlis:";
            // 
            // labelno
            // 
            this.labelno.AutoSize = true;
            this.labelno.Location = new System.Drawing.Point(487, 22);
            this.labelno.Name = "labelno";
            this.labelno.Size = new System.Drawing.Size(18, 20);
            this.labelno.TabIndex = 10;
            this.labelno.Text = "0";
            // 
            // labelDogru
            // 
            this.labelDogru.AutoSize = true;
            this.labelDogru.Location = new System.Drawing.Point(487, 54);
            this.labelDogru.Name = "labelDogru";
            this.labelDogru.Size = new System.Drawing.Size(18, 20);
            this.labelDogru.TabIndex = 9;
            this.labelDogru.Text = "0";
            // 
            // labelyanlis
            // 
            this.labelyanlis.AutoSize = true;
            this.labelyanlis.Location = new System.Drawing.Point(487, 88);
            this.labelyanlis.Name = "labelyanlis";
            this.labelyanlis.Size = new System.Drawing.Size(18, 20);
            this.labelyanlis.TabIndex = 8;
            this.labelyanlis.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(525, 26);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(186, 57);
            this.btnnext.TabIndex = 13;
            this.btnnext.Text = "Sonraki Soru";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelno);
            this.Controls.Add(this.labelDogru);
            this.Controls.Add(this.labelyanlis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelno;
        private System.Windows.Forms.Label labelDogru;
        private System.Windows.Forms.Label labelyanlis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

