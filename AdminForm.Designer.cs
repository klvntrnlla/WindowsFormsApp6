namespace WindowsFormsApp6
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.signoutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Button();
            this.cupButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backButton1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cupTextBoxPass = new System.Windows.Forms.TextBox();
            this.cupTextBoxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.usName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backButton2 = new System.Windows.Forms.Button();
            this.updatePassword = new System.Windows.Forms.Button();
            this.npTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Admin!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 481);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.signoutButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.upButton);
            this.tabPage1.Controls.Add(this.cupButton);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Page";
            // 
            // signoutButton
            // 
            this.signoutButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.signoutButton.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutButton.Location = new System.Drawing.Point(615, 170);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(236, 100);
            this.signoutButton.TabIndex = 3;
            this.signoutButton.Text = "Sign Out";
            this.signoutButton.UseVisualStyleBackColor = false;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "What do you want to do?";
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.upButton.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(341, 170);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(236, 100);
            this.upButton.TabIndex = 1;
            this.upButton.Text = "UpdatePassword";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // cupButton
            // 
            this.cupButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cupButton.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupButton.Location = new System.Drawing.Point(40, 170);
            this.cupButton.Name = "cupButton";
            this.cupButton.Size = new System.Drawing.Size(259, 100);
            this.cupButton.TabIndex = 0;
            this.cupButton.Text = "Create User Player";
            this.cupButton.UseVisualStyleBackColor = false;
            this.cupButton.Click += new System.EventHandler(this.cupButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Indigo;
            this.tabPage2.Controls.Add(this.backButton1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.cupTextBoxPass);
            this.tabPage2.Controls.Add(this.cupTextBoxUsername);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create User Player";
            // 
            // backButton1
            // 
            this.backButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton1.ForeColor = System.Drawing.Color.White;
            this.backButton1.Location = new System.Drawing.Point(28, 385);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(145, 45);
            this.backButton1.TabIndex = 5;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = false;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button4.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(374, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Create Account";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cupTextBoxPass
            // 
            this.cupTextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupTextBoxPass.Location = new System.Drawing.Point(28, 311);
            this.cupTextBoxPass.Name = "cupTextBoxPass";
            this.cupTextBoxPass.Size = new System.Drawing.Size(685, 38);
            this.cupTextBoxPass.TabIndex = 3;
            // 
            // cupTextBoxUsername
            // 
            this.cupTextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupTextBoxUsername.Location = new System.Drawing.Point(28, 182);
            this.cupTextBoxUsername.Name = "cupTextBoxUsername";
            this.cupTextBoxUsername.Size = new System.Drawing.Size(685, 38);
            this.cupTextBoxUsername.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Create User Player Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(485, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create User Player Username :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.usName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.backButton2);
            this.tabPage3.Controls.Add(this.updatePassword);
            this.tabPage3.Controls.Add(this.npTextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.oldPasswordTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(896, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UpdatePassword";
            // 
            // usName
            // 
            this.usName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usName.Location = new System.Drawing.Point(29, 86);
            this.usName.Name = "usName";
            this.usName.Size = new System.Drawing.Size(684, 38);
            this.usName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(23, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Username :";
            // 
            // backButton2
            // 
            this.backButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton2.ForeColor = System.Drawing.Color.White;
            this.backButton2.Location = new System.Drawing.Point(29, 377);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(140, 49);
            this.backButton2.TabIndex = 5;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = false;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // updatePassword
            // 
            this.updatePassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updatePassword.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassword.ForeColor = System.Drawing.Color.White;
            this.updatePassword.Location = new System.Drawing.Point(398, 377);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(140, 49);
            this.updatePassword.TabIndex = 4;
            this.updatePassword.Text = "Update Password";
            this.updatePassword.UseVisualStyleBackColor = false;
            this.updatePassword.Click += new System.EventHandler(this.updatePassword_Click);
            // 
            // npTextBox
            // 
            this.npTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npTextBox.Location = new System.Drawing.Point(29, 304);
            this.npTextBox.Name = "npTextBox";
            this.npTextBox.Size = new System.Drawing.Size(684, 38);
            this.npTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(23, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "New Password :";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(29, 195);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(684, 38);
            this.oldPasswordTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(23, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Old Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(928, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button cupButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox cupTextBoxPass;
        private System.Windows.Forms.TextBox cupTextBoxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button updatePassword;
        private System.Windows.Forms.TextBox npTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usName;
        private System.Windows.Forms.Label label8;
    }
}