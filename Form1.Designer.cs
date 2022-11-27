namespace McNameeLab2
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
            this.gb_multiplier = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.answertxt = new System.Windows.Forms.Label();
            this.lblans = new System.Windows.Forms.Label();
            this.multitxt = new System.Windows.Forms.Label();
            this.numtxt = new System.Windows.Forms.Label();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.btnpicture = new System.Windows.Forms.Button();
            this.piclabel = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.gb_multiplier.SuspendLayout();
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_multiplier
            // 
            this.gb_multiplier.Controls.Add(this.btnreset);
            this.gb_multiplier.Controls.Add(this.btncalc);
            this.gb_multiplier.Controls.Add(this.answertxt);
            this.gb_multiplier.Controls.Add(this.lblans);
            this.gb_multiplier.Controls.Add(this.multitxt);
            this.gb_multiplier.Controls.Add(this.numtxt);
            this.gb_multiplier.Controls.Add(this.textbox2);
            this.gb_multiplier.Controls.Add(this.textbox1);
            this.gb_multiplier.Location = new System.Drawing.Point(12, 32);
            this.gb_multiplier.Name = "gb_multiplier";
            this.gb_multiplier.Size = new System.Drawing.Size(250, 279);
            this.gb_multiplier.TabIndex = 0;
            this.gb_multiplier.TabStop = false;
            this.gb_multiplier.Text = "Multiplier";
            // 
            // btnreset
            // 
            this.btnreset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreset.Location = new System.Drawing.Point(126, 215);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(85, 45);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(35, 215);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(85, 45);
            this.btncalc.TabIndex = 2;
            this.btncalc.Text = "&Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // answertxt
            // 
            this.answertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answertxt.Location = new System.Drawing.Point(126, 158);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(100, 27);
            this.answertxt.TabIndex = 5;
            // 
            // lblans
            // 
            this.lblans.AutoSize = true;
            this.lblans.Location = new System.Drawing.Point(24, 159);
            this.lblans.Name = "lblans";
            this.lblans.Size = new System.Drawing.Size(63, 19);
            this.lblans.TabIndex = 4;
            this.lblans.Text = "Answer";
            // 
            // multitxt
            // 
            this.multitxt.AutoSize = true;
            this.multitxt.Location = new System.Drawing.Point(24, 103);
            this.multitxt.Name = "multitxt";
            this.multitxt.Size = new System.Drawing.Size(73, 19);
            this.multitxt.TabIndex = 3;
            this.multitxt.Text = "Multiplier";
            // 
            // numtxt
            // 
            this.numtxt.AutoSize = true;
            this.numtxt.Location = new System.Drawing.Point(24, 57);
            this.numtxt.Name = "numtxt";
            this.numtxt.Size = new System.Drawing.Size(66, 19);
            this.numtxt.TabIndex = 2;
            this.numtxt.Text = "Number";
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(126, 103);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 27);
            this.textbox2.TabIndex = 1;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(126, 49);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 27);
            this.textbox1.TabIndex = 0;
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lbldata);
            this.gb_info.Controls.Add(this.btnexit);
            this.gb_info.Controls.Add(this.btnhide);
            this.gb_info.Controls.Add(this.btndata);
            this.gb_info.Controls.Add(this.btnpicture);
            this.gb_info.Controls.Add(this.piclabel);
            this.gb_info.Controls.Add(this.picturebox);
            this.gb_info.Location = new System.Drawing.Point(299, 32);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(406, 279);
            this.gb_info.TabIndex = 1;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Information";
            // 
            // lbldata
            // 
            this.lbldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldata.Location = new System.Drawing.Point(23, 78);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(360, 129);
            this.lbldata.TabIndex = 6;
            this.lbldata.Visible = false;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(296, 215);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(85, 45);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnhide
            // 
            this.btnhide.Location = new System.Drawing.Point(205, 215);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(85, 45);
            this.btnhide.TabIndex = 2;
            this.btnhide.Text = "&Hide";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // btndata
            // 
            this.btndata.Location = new System.Drawing.Point(114, 215);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(85, 45);
            this.btndata.TabIndex = 1;
            this.btndata.Text = "&Data";
            this.btndata.UseVisualStyleBackColor = true;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // btnpicture
            // 
            this.btnpicture.Location = new System.Drawing.Point(23, 215);
            this.btnpicture.Name = "btnpicture";
            this.btnpicture.Size = new System.Drawing.Size(85, 45);
            this.btnpicture.TabIndex = 0;
            this.btnpicture.Text = "&Picture";
            this.btnpicture.UseVisualStyleBackColor = true;
            this.btnpicture.Click += new System.EventHandler(this.btnpicture_Click);
            // 
            // piclabel
            // 
            this.piclabel.AutoSize = true;
            this.piclabel.Location = new System.Drawing.Point(149, 23);
            this.piclabel.Name = "piclabel";
            this.piclabel.Size = new System.Drawing.Size(110, 19);
            this.piclabel.TabIndex = 1;
            this.piclabel.Text = "My Cat Adolin";
            // 
            // picturebox
            // 
            this.picturebox.Image = global::McNameeLab2.Properties.Resources.Adolin;
            this.picturebox.Location = new System.Drawing.Point(23, 78);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(360, 129);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.Visible = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnpicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnreset;
            this.ClientSize = new System.Drawing.Size(717, 323);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.gb_multiplier);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Jon McNamee";
            this.gb_multiplier.ResumeLayout(false);
            this.gb_multiplier.PerformLayout();
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_multiplier;
        private System.Windows.Forms.Label multitxt;
        private System.Windows.Forms.Label numtxt;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label piclabel;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label answertxt;
        private System.Windows.Forms.Label lblans;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.Button btnpicture;
        private System.Windows.Forms.Label lbldata;
    }
}

