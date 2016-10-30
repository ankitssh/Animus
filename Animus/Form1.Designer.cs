namespace Animus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.recordimages = new System.Windows.Forms.ImageList(this.components);
            this.Searchbtn = new System.Windows.Forms.Button();
            this.answerbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gB = new System.Windows.Forms.Button();
            this.exB = new System.Windows.Forms.Button();
            this.wB = new System.Windows.Forms.Button();
            this.tB = new System.Windows.Forms.Button();
            this.cB = new System.Windows.Forms.Button();
            this.eB = new System.Windows.Forms.Button();
            this.mB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lblcpu = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.cpulabel = new System.Windows.Forms.Label();
            this.ramlabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbox
            // 
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbox.Location = new System.Drawing.Point(92, 479);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(324, 30);
            this.Searchbox.TabIndex = 0;
            // 
            // recordimages
            // 
            this.recordimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("recordimages.ImageStream")));
            this.recordimages.TransparentColor = System.Drawing.Color.Transparent;
            this.recordimages.Images.SetKeyName(0, "record.png");
            this.recordimages.Images.SetKeyName(1, "record_clicked.png");
            this.recordimages.Images.SetKeyName(2, "record_hover.png");
            // 
            // Searchbtn
            // 
            this.Searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Searchbtn.FlatAppearance.BorderSize = 3;
            this.Searchbtn.Image = global::Animus.Properties.Resources.search_small;
            this.Searchbtn.Location = new System.Drawing.Point(10, 457);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(86, 66);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // answerbox
            // 
            this.answerbox.BackColor = System.Drawing.Color.Black;
            this.answerbox.Enabled = false;
            this.answerbox.Font = new System.Drawing.Font("Tekton Pro Ext", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answerbox.Location = new System.Drawing.Point(12, 41);
            this.answerbox.Multiline = true;
            this.answerbox.Name = "answerbox";
            this.answerbox.Size = new System.Drawing.Size(575, 151);
            this.answerbox.TabIndex = 3;
            this.answerbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Response";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(834, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(873, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listening...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Animus.Properties.Resources.waves;
            this.pictureBox2.Location = new System.Drawing.Point(525, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // gB
            // 
            this.gB.BackColor = System.Drawing.Color.Black;
            this.gB.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.gB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB.ForeColor = System.Drawing.Color.DarkGreen;
            this.gB.Location = new System.Drawing.Point(642, 169);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(103, 23);
            this.gB.TabIndex = 8;
            this.gB.Text = "Google";
            this.gB.UseVisualStyleBackColor = false;
            this.gB.Click += new System.EventHandler(this.gB_Click);
            // 
            // exB
            // 
            this.exB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.exB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exB.ForeColor = System.Drawing.Color.DarkGreen;
            this.exB.Location = new System.Drawing.Point(749, 336);
            this.exB.Name = "exB";
            this.exB.Size = new System.Drawing.Size(79, 23);
            this.exB.TabIndex = 9;
            this.exB.Text = "Explorer";
            this.exB.UseVisualStyleBackColor = true;
            this.exB.Click += new System.EventHandler(this.hB_Click);
            // 
            // wB
            // 
            this.wB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.wB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wB.ForeColor = System.Drawing.Color.DarkGreen;
            this.wB.Location = new System.Drawing.Point(708, 235);
            this.wB.Name = "wB";
            this.wB.Size = new System.Drawing.Size(95, 23);
            this.wB.TabIndex = 10;
            this.wB.Text = "Weather";
            this.wB.UseVisualStyleBackColor = true;
            this.wB.Click += new System.EventHandler(this.wB_Click);
            // 
            // tB
            // 
            this.tB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.tB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB.ForeColor = System.Drawing.Color.DarkGreen;
            this.tB.Location = new System.Drawing.Point(789, 169);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(137, 23);
            this.tB.TabIndex = 11;
            this.tB.Text = "Task Manager";
            this.tB.UseVisualStyleBackColor = true;
            this.tB.Click += new System.EventHandler(this.tB_Click);
            // 
            // cB
            // 
            this.cB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.cB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB.ForeColor = System.Drawing.Color.DarkGreen;
            this.cB.Location = new System.Drawing.Point(825, 261);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(137, 23);
            this.cB.TabIndex = 13;
            this.cB.Text = "Control Panel";
            this.cB.UseVisualStyleBackColor = true;
            this.cB.Click += new System.EventHandler(this.cB_Click);
            // 
            // eB
            // 
            this.eB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eB.Location = new System.Drawing.Point(905, 486);
            this.eB.Name = "eB";
            this.eB.Size = new System.Drawing.Size(75, 23);
            this.eB.TabIndex = 14;
            this.eB.Text = "Exit";
            this.eB.UseVisualStyleBackColor = true;
            this.eB.Click += new System.EventHandler(this.eB_Click);
            // 
            // mB
            // 
            this.mB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mB.ForeColor = System.Drawing.Color.Red;
            this.mB.Location = new System.Drawing.Point(781, 486);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(108, 23);
            this.mB.TabIndex = 15;
            this.mB.Text = "Machine Off";
            this.mB.UseVisualStyleBackColor = true;
            this.mB.Click += new System.EventHandler(this.mB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(642, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date & Time";
            // 
            // dT
            // 
            this.dT.AutoSize = true;
            this.dT.ForeColor = System.Drawing.Color.Red;
            this.dT.Location = new System.Drawing.Point(642, 58);
            this.dT.Name = "dT";
            this.dT.Size = new System.Drawing.Size(74, 17);
            this.dT.TabIndex = 17;
            this.dT.Text = "Fetching...";
            this.dT.Click += new System.EventHandler(this.dT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Animus.Properties.Resources.thGreenBarGraph_gif_c200;
            this.pictureBox3.Location = new System.Drawing.Point(10, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Animus.Properties.Resources.hud;
            this.pictureBox4.Location = new System.Drawing.Point(149, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(324, 253);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Black;
            this.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnEnable.Location = new System.Drawing.Point(437, 486);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(166, 23);
            this.btnEnable.TabIndex = 20;
            this.btnEnable.Text = "Enable Voice";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Black;
            this.btnDisable.Enabled = false;
            this.btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnDisable.Location = new System.Drawing.Point(609, 486);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(166, 23);
            this.btnDisable.TabIndex = 21;
            this.btnDisable.Text = "Disable Voice";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lblcpu
            // 
            this.lblcpu.AutoSize = true;
            this.lblcpu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblcpu.Location = new System.Drawing.Point(504, 267);
            this.lblcpu.Name = "lblcpu";
            this.lblcpu.Size = new System.Drawing.Size(85, 17);
            this.lblcpu.TabIndex = 22;
            this.lblcpu.Text = "CPU Usage:";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRam.Location = new System.Drawing.Point(504, 300);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(103, 17);
            this.lblRam.TabIndex = 23;
            this.lblRam.Text = "RAM Available:";
            // 
            // cpulabel
            // 
            this.cpulabel.AutoSize = true;
            this.cpulabel.ForeColor = System.Drawing.Color.Crimson;
            this.cpulabel.Location = new System.Drawing.Point(606, 267);
            this.cpulabel.Name = "cpulabel";
            this.cpulabel.Size = new System.Drawing.Size(74, 17);
            this.cpulabel.TabIndex = 24;
            this.cpulabel.Text = "Fetching...";
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.ForeColor = System.Drawing.Color.Crimson;
            this.ramlabel.Location = new System.Drawing.Point(606, 300);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Size = new System.Drawing.Size(74, 17);
            this.ramlabel.TabIndex = 25;
            this.ramlabel.Text = "Fetching...";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Animus.Properties.Resources.animus_final_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(992, 535);
            this.Controls.Add(this.ramlabel);
            this.Controls.Add(this.cpulabel);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblcpu);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mB);
            this.Controls.Add(this.eB);
            this.Controls.Add(this.cB);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.wB);
            this.Controls.Add(this.exB);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerbox);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Animus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ImageList recordimages;
        private System.Windows.Forms.TextBox answerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button gB;
        private System.Windows.Forms.Button exB;
        private System.Windows.Forms.Button wB;
        private System.Windows.Forms.Button tB;
        private System.Windows.Forms.Button cB;
        private System.Windows.Forms.Button eB;
        private System.Windows.Forms.Button mB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label lblcpu;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label cpulabel;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.Timer timer2;
    }
}

