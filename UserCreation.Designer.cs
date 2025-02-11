namespace WindowsFormsApp1
{
    partial class UserCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreation));
            this.button2 = new System.Windows.Forms.Button();
            this.Creationloginlogo = new System.Windows.Forms.PictureBox();
            this.PasswordlabelCreation = new System.Windows.Forms.Label();
            this.EmaillabelCreation = new System.Windows.Forms.Label();
            this.CreationEmailtxtbox = new System.Windows.Forms.TextBox();
            this.CreationPasswordtxtbox = new System.Windows.Forms.TextBox();
            this.NameTextboxcreation = new System.Windows.Forms.TextBox();
            this.NameCreation = new System.Windows.Forms.Label();
            this.btnSignup_click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Creationloginlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(269, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Creationloginlogo
            // 
            this.Creationloginlogo.BackColor = System.Drawing.Color.Transparent;
            this.Creationloginlogo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.luxe_prints;
            this.Creationloginlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Creationloginlogo.Location = new System.Drawing.Point(78, 30);
            this.Creationloginlogo.Name = "Creationloginlogo";
            this.Creationloginlogo.Size = new System.Drawing.Size(183, 166);
            this.Creationloginlogo.TabIndex = 18;
            this.Creationloginlogo.TabStop = false;
            // 
            // PasswordlabelCreation
            // 
            this.PasswordlabelCreation.AutoSize = true;
            this.PasswordlabelCreation.Location = new System.Drawing.Point(38, 347);
            this.PasswordlabelCreation.Name = "PasswordlabelCreation";
            this.PasswordlabelCreation.Size = new System.Drawing.Size(56, 13);
            this.PasswordlabelCreation.TabIndex = 15;
            this.PasswordlabelCreation.Text = "Password ";
            // 
            // EmaillabelCreation
            // 
            this.EmaillabelCreation.AutoSize = true;
            this.EmaillabelCreation.Location = new System.Drawing.Point(38, 277);
            this.EmaillabelCreation.Name = "EmaillabelCreation";
            this.EmaillabelCreation.Size = new System.Drawing.Size(32, 13);
            this.EmaillabelCreation.TabIndex = 14;
            this.EmaillabelCreation.Text = "Email";
            // 
            // CreationEmailtxtbox
            // 
            this.CreationEmailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationEmailtxtbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreationEmailtxtbox.Location = new System.Drawing.Point(41, 293);
            this.CreationEmailtxtbox.Multiline = true;
            this.CreationEmailtxtbox.Name = "CreationEmailtxtbox";
            this.CreationEmailtxtbox.Size = new System.Drawing.Size(268, 32);
            this.CreationEmailtxtbox.TabIndex = 13;
            // 
            // CreationPasswordtxtbox
            // 
            this.CreationPasswordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationPasswordtxtbox.Location = new System.Drawing.Point(41, 363);
            this.CreationPasswordtxtbox.Multiline = true;
            this.CreationPasswordtxtbox.Name = "CreationPasswordtxtbox";
            this.CreationPasswordtxtbox.PasswordChar = '*';
            this.CreationPasswordtxtbox.ShortcutsEnabled = false;
            this.CreationPasswordtxtbox.Size = new System.Drawing.Size(268, 35);
            this.CreationPasswordtxtbox.TabIndex = 12;
            // 
            // NameTextboxcreation
            // 
            this.NameTextboxcreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextboxcreation.Location = new System.Drawing.Point(41, 233);
            this.NameTextboxcreation.Multiline = true;
            this.NameTextboxcreation.Name = "NameTextboxcreation";
            this.NameTextboxcreation.Size = new System.Drawing.Size(268, 32);
            this.NameTextboxcreation.TabIndex = 20;
            // 
            // NameCreation
            // 
            this.NameCreation.AutoSize = true;
            this.NameCreation.Location = new System.Drawing.Point(38, 217);
            this.NameCreation.Name = "NameCreation";
            this.NameCreation.Size = new System.Drawing.Size(38, 13);
            this.NameCreation.TabIndex = 21;
            this.NameCreation.Text = "Name ";
            // 
            // btnSignup_click
            // 
            this.btnSignup_click.Location = new System.Drawing.Point(41, 452);
            this.btnSignup_click.Name = "btnSignup_click";
            this.btnSignup_click.Size = new System.Drawing.Size(268, 34);
            this.btnSignup_click.TabIndex = 22;
            this.btnSignup_click.Text = "Signup";
            this.btnSignup_click.UseVisualStyleBackColor = true;
            this.btnSignup_click.Click += new System.EventHandler(this.btnSignup_click_Click);
            // 
            // UserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 563);
            this.Controls.Add(this.btnSignup_click);
            this.Controls.Add(this.NameCreation);
            this.Controls.Add(this.NameTextboxcreation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Creationloginlogo);
            this.Controls.Add(this.PasswordlabelCreation);
            this.Controls.Add(this.EmaillabelCreation);
            this.Controls.Add(this.CreationEmailtxtbox);
            this.Controls.Add(this.CreationPasswordtxtbox);
            this.Name = "UserCreation";
            this.Load += new System.EventHandler(this.UserCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Creationloginlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Creationloginlogo;
        private System.Windows.Forms.Label PasswordlabelCreation;
        private System.Windows.Forms.Label EmaillabelCreation;
        private System.Windows.Forms.TextBox CreationEmailtxtbox;
        private System.Windows.Forms.TextBox CreationPasswordtxtbox;
        private System.Windows.Forms.TextBox NameTextboxcreation;
        private System.Windows.Forms.Label NameCreation;
        private System.Windows.Forms.Button btnSignup_click;
    }
}