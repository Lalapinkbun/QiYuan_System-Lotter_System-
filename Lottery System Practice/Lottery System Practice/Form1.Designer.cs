namespace Lottery_System_Practice
{
    partial class The_Lottery_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_Lottery_System));
            this.btnGetTen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labPlayerHasGet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labMinPlayerGet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetTen
            // 
            this.btnGetTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTen.Location = new System.Drawing.Point(976, 605);
            this.btnGetTen.Name = "btnGetTen";
            this.btnGetTen.Size = new System.Drawing.Size(180, 56);
            this.btnGetTen.TabIndex = 1;
            this.btnGetTen.Text = "抽十次";
            this.btnGetTen.UseVisualStyleBackColor = true;
            this.btnGetTen.Click += new System.EventHandler(this.btnGetTen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetOne
            // 
            this.btnGetOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOne.Location = new System.Drawing.Point(790, 605);
            this.btnGetOne.Name = "btnGetOne";
            this.btnGetOne.Size = new System.Drawing.Size(180, 56);
            this.btnGetOne.TabIndex = 2;
            this.btnGetOne.Text = "抽一次";
            this.btnGetOne.UseVisualStyleBackColor = true;
            this.btnGetOne.Click += new System.EventHandler(this.btnGetOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "玩家一共抽取了:";
            // 
            // labPlayerHasGet
            // 
            this.labPlayerHasGet.AutoSize = true;
            this.labPlayerHasGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPlayerHasGet.Location = new System.Drawing.Point(184, 605);
            this.labPlayerHasGet.Name = "labPlayerHasGet";
            this.labPlayerHasGet.Size = new System.Drawing.Size(24, 25);
            this.labPlayerHasGet.TabIndex = 4;
            this.labPlayerHasGet.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "离保底的数量:";
            // 
            // labMinPlayerGet
            // 
            this.labMinPlayerGet.AutoSize = true;
            this.labMinPlayerGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinPlayerGet.Location = new System.Drawing.Point(184, 639);
            this.labMinPlayerGet.Name = "labMinPlayerGet";
            this.labMinPlayerGet.Size = new System.Drawing.Size(24, 25);
            this.labMinPlayerGet.TabIndex = 6;
            this.labMinPlayerGet.Text = "0";
            // 
            // The_Lottery_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.labMinPlayerGet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labPlayerHasGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetOne);
            this.Controls.Add(this.btnGetTen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "The_Lottery_System";
            this.Text = "祈愿系统  Fan-Made";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPlayerHasGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labMinPlayerGet;
    }
}

