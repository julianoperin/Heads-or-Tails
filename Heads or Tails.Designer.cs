namespace Head_or_Tails
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
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.picHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeads
            // 
            this.btnHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeads.ForeColor = System.Drawing.Color.Maroon;
            this.btnHeads.Location = new System.Drawing.Point(96, 237);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(106, 30);
            this.btnHeads.TabIndex = 2;
            this.btnHeads.Text = "Show Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
            // 
            // btnTails
            // 
            this.btnTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTails.ForeColor = System.Drawing.Color.Maroon;
            this.btnTails.Location = new System.Drawing.Point(236, 237);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(106, 30);
            this.btnTails.TabIndex = 3;
            this.btnTails.Text = "Show Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoth.ForeColor = System.Drawing.Color.Maroon;
            this.btnBoth.Location = new System.Drawing.Point(96, 288);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(106, 30);
            this.btnBoth.TabIndex = 4;
            this.btnBoth.Text = "Show Both";
            this.btnBoth.UseVisualStyleBackColor = true;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(236, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTails
            // 
            this.picTails.Image = global::Head_or_Tails.Properties.Resources.Tails;
            this.picTails.Location = new System.Drawing.Point(261, 55);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(150, 150);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTails.TabIndex = 1;
            this.picTails.TabStop = false;
            // 
            // picHead
            // 
            this.picHead.Image = global::Head_or_Tails.Properties.Resources.Heads;
            this.picHead.Location = new System.Drawing.Point(38, 55);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(150, 150);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHead.TabIndex = 0;
            this.picHead.TabStop = false;
            this.picHead.Click += new System.EventHandler(this.picHead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBoth);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHead);
            this.Name = "Form1";
            this.Text = "Head or Tails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.PictureBox picTails;
        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Button btnExit;
    }
}

