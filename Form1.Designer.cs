namespace WindowsFormsApp1
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.Emailtxtbox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.LinkLabel();
            this.loginlogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Loginbutton.Location = new System.Drawing.Point(51, 417);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(268, 51);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxtbox.Location = new System.Drawing.Point(51, 362);
            this.Passwordtxtbox.Multiline = true;
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.PasswordChar = '*';
            this.Passwordtxtbox.ShortcutsEnabled = false;
            this.Passwordtxtbox.Size = new System.Drawing.Size(268, 35);
            this.Passwordtxtbox.TabIndex = 1;
            this.Passwordtxtbox.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Emailtxtbox
            // 
            this.Emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxtbox.Location = new System.Drawing.Point(51, 292);
            this.Emailtxtbox.Multiline = true;
            this.Emailtxtbox.Name = "Emailtxtbox";
            this.Emailtxtbox.Size = new System.Drawing.Size(268, 32);
            this.Emailtxtbox.TabIndex = 2;
            this.Emailtxtbox.Click += new System.EventHandler(this.textBox2_Click);
            this.Emailtxtbox.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(48, 276);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(32, 13);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "Email";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Location = new System.Drawing.Point(48, 346);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(56, 13);
            this.Passwordlabel.TabIndex = 4;
            this.Passwordlabel.Text = "Password ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN TO YOUR LUXEPRINTS PH ACCOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter your email and password below";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Don\'t have an account?";
            // 
            // signupbtn
            // 
            this.signupbtn.AutoSize = true;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(226, 494);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(52, 16);
            this.signupbtn.TabIndex = 8;
            this.signupbtn.TabStop = true;
            this.signupbtn.Text = "Sign up";
            this.signupbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupbtn_LinkClicked);
            // 
            // loginlogo
            // 
            this.loginlogo.BackColor = System.Drawing.Color.Transparent;
            this.loginlogo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.luxe_prints;
            this.loginlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginlogo.Location = new System.Drawing.Point(82, 26);
            this.loginlogo.Name = "loginlogo";
            this.loginlogo.Size = new System.Drawing.Size(183, 166);
            this.loginlogo.TabIndex = 9;
            this.loginlogo.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(279, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginlogo);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Emailtxtbox);
            this.Controls.Add(this.Passwordtxtbox);
            this.Controls.Add(this.Loginbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Loginform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox Passwordtxtbox;
        private System.Windows.Forms.TextBox Emailtxtbox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel signupbtn;
        private System.Windows.Forms.PictureBox loginlogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Passwordlabel;
    }
}

