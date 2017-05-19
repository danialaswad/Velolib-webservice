namespace ClientWAF
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.walkStart = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.walkEnd = new System.Windows.Forms.RichTextBox();
            this.walkDistance = new System.Windows.Forms.RichTextBox();
            this.walkDuration = new System.Windows.Forms.RichTextBox();
            this.walkPicture = new System.Windows.Forms.PictureBox();
            this.cyclePicture = new System.Windows.Forms.PictureBox();
            this.cycleDuration = new System.Windows.Forms.RichTextBox();
            this.cycleDistance = new System.Windows.Forms.RichTextBox();
            this.cycleEnd = new System.Windows.Forms.RichTextBox();
            this.cycleStart = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.walkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depart  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // walkStart
            // 
            this.walkStart.BackColor = System.Drawing.SystemColors.Control;
            this.walkStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walkStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkStart.Location = new System.Drawing.Point(30, 97);
            this.walkStart.Name = "walkStart";
            this.walkStart.ReadOnly = true;
            this.walkStart.Size = new System.Drawing.Size(206, 50);
            this.walkStart.TabIndex = 3;
            this.walkStart.Text = "";
            this.walkStart.Visible = false;
            this.walkStart.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // walkEnd
            // 
            this.walkEnd.BackColor = System.Drawing.SystemColors.Control;
            this.walkEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walkEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkEnd.Location = new System.Drawing.Point(499, 97);
            this.walkEnd.Name = "walkEnd";
            this.walkEnd.ReadOnly = true;
            this.walkEnd.Size = new System.Drawing.Size(206, 50);
            this.walkEnd.TabIndex = 7;
            this.walkEnd.Text = "";
            this.walkEnd.Visible = false;
            this.walkEnd.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // walkDistance
            // 
            this.walkDistance.BackColor = System.Drawing.SystemColors.Control;
            this.walkDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walkDistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkDistance.Location = new System.Drawing.Point(201, 168);
            this.walkDistance.Name = "walkDistance";
            this.walkDistance.ReadOnly = true;
            this.walkDistance.Size = new System.Drawing.Size(134, 24);
            this.walkDistance.TabIndex = 8;
            this.walkDistance.Text = "";
            this.walkDistance.Visible = false;
            // 
            // walkDuration
            // 
            this.walkDuration.BackColor = System.Drawing.SystemColors.Control;
            this.walkDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walkDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkDuration.Location = new System.Drawing.Point(386, 168);
            this.walkDuration.Name = "walkDuration";
            this.walkDuration.ReadOnly = true;
            this.walkDuration.Size = new System.Drawing.Size(134, 24);
            this.walkDuration.TabIndex = 9;
            this.walkDuration.Text = "";
            this.walkDuration.Visible = false;
            // 
            // walkPicture
            // 
            this.walkPicture.Image = ((System.Drawing.Image)(resources.GetObject("walkPicture.Image")));
            this.walkPicture.Location = new System.Drawing.Point(320, 97);
            this.walkPicture.Name = "walkPicture";
            this.walkPicture.Size = new System.Drawing.Size(100, 50);
            this.walkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.walkPicture.TabIndex = 10;
            this.walkPicture.TabStop = false;
            this.walkPicture.Visible = false;
            // 
            // cyclePicture
            // 
            this.cyclePicture.Image = ((System.Drawing.Image)(resources.GetObject("cyclePicture.Image")));
            this.cyclePicture.Location = new System.Drawing.Point(318, 218);
            this.cyclePicture.Name = "cyclePicture";
            this.cyclePicture.Size = new System.Drawing.Size(100, 50);
            this.cyclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cyclePicture.TabIndex = 15;
            this.cyclePicture.TabStop = false;
            this.cyclePicture.Visible = false;
            // 
            // cycleDuration
            // 
            this.cycleDuration.BackColor = System.Drawing.SystemColors.Control;
            this.cycleDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycleDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleDuration.Location = new System.Drawing.Point(384, 289);
            this.cycleDuration.Name = "cycleDuration";
            this.cycleDuration.ReadOnly = true;
            this.cycleDuration.Size = new System.Drawing.Size(134, 24);
            this.cycleDuration.TabIndex = 14;
            this.cycleDuration.Text = "";
            this.cycleDuration.Visible = false;
            // 
            // cycleDistance
            // 
            this.cycleDistance.BackColor = System.Drawing.SystemColors.Control;
            this.cycleDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycleDistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleDistance.Location = new System.Drawing.Point(199, 289);
            this.cycleDistance.Name = "cycleDistance";
            this.cycleDistance.ReadOnly = true;
            this.cycleDistance.Size = new System.Drawing.Size(134, 24);
            this.cycleDistance.TabIndex = 13;
            this.cycleDistance.Text = "";
            this.cycleDistance.Visible = false;
            // 
            // cycleEnd
            // 
            this.cycleEnd.BackColor = System.Drawing.SystemColors.Control;
            this.cycleEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycleEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleEnd.Location = new System.Drawing.Point(497, 218);
            this.cycleEnd.Name = "cycleEnd";
            this.cycleEnd.ReadOnly = true;
            this.cycleEnd.Size = new System.Drawing.Size(206, 50);
            this.cycleEnd.TabIndex = 12;
            this.cycleEnd.Text = "";
            this.cycleEnd.Visible = false;
            // 
            // cycleStart
            // 
            this.cycleStart.BackColor = System.Drawing.SystemColors.Control;
            this.cycleStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cycleStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleStart.Location = new System.Drawing.Point(28, 218);
            this.cycleStart.Name = "cycleStart";
            this.cycleStart.ReadOnly = true;
            this.cycleStart.Size = new System.Drawing.Size(206, 50);
            this.cycleStart.TabIndex = 11;
            this.cycleStart.Text = "";
            this.cycleStart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(738, 336);
            this.Controls.Add(this.cyclePicture);
            this.Controls.Add(this.cycleDuration);
            this.Controls.Add(this.cycleDistance);
            this.Controls.Add(this.cycleEnd);
            this.Controls.Add(this.cycleStart);
            this.Controls.Add(this.walkPicture);
            this.Controls.Add(this.walkDuration);
            this.Controls.Add(this.walkDistance);
            this.Controls.Add(this.walkEnd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.walkStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Velolib Itenary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.walkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox walkStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox walkEnd;
        private System.Windows.Forms.RichTextBox walkDistance;
        private System.Windows.Forms.RichTextBox walkDuration;
        private System.Windows.Forms.PictureBox walkPicture;
        private System.Windows.Forms.PictureBox cyclePicture;
        private System.Windows.Forms.RichTextBox cycleDuration;
        private System.Windows.Forms.RichTextBox cycleDistance;
        private System.Windows.Forms.RichTextBox cycleEnd;
        private System.Windows.Forms.RichTextBox cycleStart;
    }
}

