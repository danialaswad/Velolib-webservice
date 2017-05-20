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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cycleDuration = new System.Windows.Forms.RichTextBox();
            this.cyclePicture = new System.Windows.Forms.PictureBox();
            this.cycleDistance = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cycleEnd = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cycleStart = new System.Windows.Forms.RichTextBox();
            this.walkStart = new System.Windows.Forms.RichTextBox();
            this.walkDuration = new System.Windows.Forms.RichTextBox();
            this.walkPicture = new System.Windows.Forms.PictureBox();
            this.walkDistance = new System.Windows.Forms.RichTextBox();
            this.walkEnd = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.walkView = new System.Windows.Forms.ListView();
            this.Itinerary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cycleView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.cyclePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 36;
            // 
            // cycleDuration
            // 
            this.cycleDuration.BackColor = System.Drawing.SystemColors.Control;
            this.cycleDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cycleDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleDuration.Location = new System.Drawing.Point(220, 427);
            this.cycleDuration.Name = "cycleDuration";
            this.cycleDuration.ReadOnly = true;
            this.cycleDuration.Size = new System.Drawing.Size(105, 24);
            this.cycleDuration.TabIndex = 46;
            this.cycleDuration.Text = "";
            // 
            // cyclePicture
            // 
            this.cyclePicture.Image = ((System.Drawing.Image)(resources.GetObject("cyclePicture.Image")));
            this.cyclePicture.Location = new System.Drawing.Point(159, 423);
            this.cyclePicture.Name = "cyclePicture";
            this.cyclePicture.Size = new System.Drawing.Size(36, 36);
            this.cyclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cyclePicture.TabIndex = 47;
            this.cyclePicture.TabStop = false;
            // 
            // cycleDistance
            // 
            this.cycleDistance.BackColor = System.Drawing.SystemColors.Control;
            this.cycleDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cycleDistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleDistance.Location = new System.Drawing.Point(25, 427);
            this.cycleDistance.Name = "cycleDistance";
            this.cycleDistance.ReadOnly = true;
            this.cycleDistance.Size = new System.Drawing.Size(105, 24);
            this.cycleDistance.TabIndex = 45;
            this.cycleDistance.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Depart  :";
            // 
            // cycleEnd
            // 
            this.cycleEnd.BackColor = System.Drawing.SystemColors.Control;
            this.cycleEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cycleEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleEnd.Location = new System.Drawing.Point(25, 470);
            this.cycleEnd.Name = "cycleEnd";
            this.cycleEnd.ReadOnly = true;
            this.cycleEnd.Size = new System.Drawing.Size(300, 30);
            this.cycleEnd.TabIndex = 44;
            this.cycleEnd.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Destination  :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 37;
            // 
            // cycleStart
            // 
            this.cycleStart.BackColor = System.Drawing.SystemColors.Control;
            this.cycleStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cycleStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleStart.Location = new System.Drawing.Point(25, 383);
            this.cycleStart.Name = "cycleStart";
            this.cycleStart.ReadOnly = true;
            this.cycleStart.Size = new System.Drawing.Size(300, 28);
            this.cycleStart.TabIndex = 43;
            this.cycleStart.Text = "";
            // 
            // walkStart
            // 
            this.walkStart.BackColor = System.Drawing.SystemColors.Control;
            this.walkStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walkStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkStart.Location = new System.Drawing.Point(25, 189);
            this.walkStart.Name = "walkStart";
            this.walkStart.ReadOnly = true;
            this.walkStart.Size = new System.Drawing.Size(300, 27);
            this.walkStart.TabIndex = 35;
            this.walkStart.Text = "";
            // 
            // walkDuration
            // 
            this.walkDuration.BackColor = System.Drawing.SystemColors.Control;
            this.walkDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walkDuration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkDuration.Location = new System.Drawing.Point(220, 232);
            this.walkDuration.Name = "walkDuration";
            this.walkDuration.ReadOnly = true;
            this.walkDuration.Size = new System.Drawing.Size(105, 24);
            this.walkDuration.TabIndex = 41;
            this.walkDuration.Text = "";
            // 
            // walkPicture
            // 
            this.walkPicture.Image = ((System.Drawing.Image)(resources.GetObject("walkPicture.Image")));
            this.walkPicture.Location = new System.Drawing.Point(159, 232);
            this.walkPicture.Name = "walkPicture";
            this.walkPicture.Size = new System.Drawing.Size(36, 27);
            this.walkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.walkPicture.TabIndex = 42;
            this.walkPicture.TabStop = false;
            // 
            // walkDistance
            // 
            this.walkDistance.BackColor = System.Drawing.SystemColors.Control;
            this.walkDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walkDistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkDistance.Location = new System.Drawing.Point(25, 233);
            this.walkDistance.Name = "walkDistance";
            this.walkDistance.ReadOnly = true;
            this.walkDistance.Size = new System.Drawing.Size(105, 23);
            this.walkDistance.TabIndex = 40;
            this.walkDistance.Text = "";
            // 
            // walkEnd
            // 
            this.walkEnd.BackColor = System.Drawing.SystemColors.Control;
            this.walkEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walkEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkEnd.Location = new System.Drawing.Point(25, 275);
            this.walkEnd.Name = "walkEnd";
            this.walkEnd.ReadOnly = true;
            this.walkEnd.Size = new System.Drawing.Size(300, 27);
            this.walkEnd.TabIndex = 39;
            this.walkEnd.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Go!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // walkView
            // 
            this.walkView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Itinerary,
            this.Distance,
            this.Duration});
            this.walkView.FullRowSelect = true;
            this.walkView.GridLines = true;
            this.walkView.Location = new System.Drawing.Point(363, 23);
            this.walkView.Name = "walkView";
            this.walkView.Size = new System.Drawing.Size(547, 233);
            this.walkView.TabIndex = 52;
            this.walkView.UseCompatibleStateImageBehavior = false;
            this.walkView.View = System.Windows.Forms.View.Details;
            this.walkView.SelectedIndexChanged += new System.EventHandler(this.walkView_SelectedIndexChanged);
            // 
            // Itinerary
            // 
            this.Itinerary.Text = "Walking Itinerary";
            this.Itinerary.Width = 352;
            // 
            // Distance
            // 
            this.Distance.Text = "Distance";
            this.Distance.Width = 104;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 87;
            // 
            // cycleView
            // 
            this.cycleView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.cycleView.FullRowSelect = true;
            this.cycleView.GridLines = true;
            this.cycleView.Location = new System.Drawing.Point(363, 287);
            this.cycleView.Name = "cycleView";
            this.cycleView.Size = new System.Drawing.Size(547, 233);
            this.cycleView.TabIndex = 53;
            this.cycleView.UseCompatibleStateImageBehavior = false;
            this.cycleView.View = System.Windows.Forms.View.Details;
            this.cycleView.SelectedIndexChanged += new System.EventHandler(this.cycleView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cycling Itinerary";
            this.columnHeader1.Width = 351;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Distance";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.cycleView);
            this.Controls.Add(this.walkView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cycleDuration);
            this.Controls.Add(this.cyclePicture);
            this.Controls.Add(this.cycleDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cycleEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cycleStart);
            this.Controls.Add(this.walkStart);
            this.Controls.Add(this.walkDuration);
            this.Controls.Add(this.walkPicture);
            this.Controls.Add(this.walkDistance);
            this.Controls.Add(this.walkEnd);
            this.Name = "Form1";
            this.Text = "Velolib Itenary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyclePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox cycleDuration;
        private System.Windows.Forms.PictureBox cyclePicture;
        private System.Windows.Forms.RichTextBox cycleDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cycleEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox cycleStart;
        private System.Windows.Forms.RichTextBox walkStart;
        private System.Windows.Forms.RichTextBox walkDuration;
        private System.Windows.Forms.PictureBox walkPicture;
        private System.Windows.Forms.RichTextBox walkDistance;
        private System.Windows.Forms.RichTextBox walkEnd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView walkView;
        private System.Windows.Forms.ColumnHeader Itinerary;
        private System.Windows.Forms.ColumnHeader Distance;
        private System.Windows.Forms.ListView cycleView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

