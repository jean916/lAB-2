namespace mushrooms
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
            this.lblBicycleTitle = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBicycleLogout = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.btnChooseLogout = new System.Windows.Forms.Button();
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.lblChooseTitle = new System.Windows.Forms.Label();
            this.panelBicycle = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEndDescription = new System.Windows.Forms.Label();
            this.panelMushroom = new System.Windows.Forms.Panel();
            this.btnMushroomLogout = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelChoose.SuspendLayout();
            this.panelBicycle.SuspendLayout();
            this.panelMushroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBicycleTitle
            // 
            this.lblBicycleTitle.AutoSize = true;
            this.lblBicycleTitle.Location = new System.Drawing.Point(155, 10);
            this.lblBicycleTitle.Name = "lblBicycleTitle";
            this.lblBicycleTitle.Size = new System.Drawing.Size(145, 20);
            this.lblBicycleTitle.TabIndex = 7;
            this.lblBicycleTitle.Text = "BICYCLE RENTAL";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(10, 90);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(151, 20);
            this.lblStart.TabIndex = 8;
            this.lblStart.Text = "Starting Hour (0–23)";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(180, 84);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(117, 26);
            this.nudStart.TabIndex = 9;
            // 
            // nudEnd
            // 
            this.nudEnd.Location = new System.Drawing.Point(180, 133);
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(117, 26);
            this.nudEnd.TabIndex = 11;
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Location = new System.Drawing.Point(97, 445);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(0, 20);
            this.lblLoginMessage.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(82, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(313, 45);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total to pay: 0 RWF";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(119, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(197, 45);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "CALCULATE RENTAL";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBicycleLogout
            // 
            this.btnBicycleLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnBicycleLogout.ForeColor = System.Drawing.Color.White;
            this.btnBicycleLogout.Location = new System.Drawing.Point(159, 391);
            this.btnBicycleLogout.Name = "btnBicycleLogout";
            this.btnBicycleLogout.Size = new System.Drawing.Size(117, 40);
            this.btnBicycleLogout.TabIndex = 15;
            this.btnBicycleLogout.Text = "LOGOUT";
            this.btnBicycleLogout.UseVisualStyleBackColor = false;
            this.btnBicycleLogout.Click += new System.EventHandler(this.btnBicycleLogout_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.lblLoginTitle);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(560, 450);
            this.panelLogin.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(129, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 26);
            this.txtUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(173, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Location = new System.Drawing.Point(124, 28);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(91, 20);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "WELCOME";
            // 
            // panelChoose
            // 
            this.panelChoose.BackColor = System.Drawing.Color.White;
            this.panelChoose.Controls.Add(this.btnChooseLogout);
            this.panelChoose.Controls.Add(this.btnBicycle);
            this.panelChoose.Controls.Add(this.btnMushroom);
            this.panelChoose.Controls.Add(this.lblChooseTitle);
            this.panelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChoose.Location = new System.Drawing.Point(0, 0);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(560, 450);
            this.panelChoose.TabIndex = 10;
            // 
            // btnChooseLogout
            // 
            this.btnChooseLogout.Location = new System.Drawing.Point(244, 200);
            this.btnChooseLogout.Name = "btnChooseLogout";
            this.btnChooseLogout.Size = new System.Drawing.Size(83, 29);
            this.btnChooseLogout.TabIndex = 3;
            this.btnChooseLogout.Text = "LOGOUT";
            this.btnChooseLogout.UseVisualStyleBackColor = true;
            this.btnChooseLogout.Click += new System.EventHandler(this.btnChooseLogout_Click);
            // 
            // btnBicycle
            // 
            this.btnBicycle.Location = new System.Drawing.Point(262, 106);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(138, 36);
            this.btnBicycle.TabIndex = 2;
            this.btnBicycle.Text = "BICYCLE";
            this.btnBicycle.UseVisualStyleBackColor = true;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            // 
            // btnMushroom
            // 
            this.btnMushroom.Location = new System.Drawing.Point(47, 106);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(122, 36);
            this.btnMushroom.TabIndex = 1;
            this.btnMushroom.Text = "MUSHROOM";
            this.btnMushroom.UseVisualStyleBackColor = true;
            this.btnMushroom.Click += new System.EventHandler(this.btnMushroom_Click);
            // 
            // lblChooseTitle
            // 
            this.lblChooseTitle.AutoSize = true;
            this.lblChooseTitle.Location = new System.Drawing.Point(194, 23);
            this.lblChooseTitle.Name = "lblChooseTitle";
            this.lblChooseTitle.Size = new System.Drawing.Size(183, 20);
            this.lblChooseTitle.TabIndex = 0;
            this.lblChooseTitle.Text = "CHOOSE AN OPTION";
            // 
            // panelBicycle
            // 
            this.panelBicycle.Controls.Add(this.lblDuration);
            this.panelBicycle.Controls.Add(this.lblEndDescription);
            this.panelBicycle.Controls.Add(this.lblBicycleTitle);
            this.panelBicycle.Controls.Add(this.lblStart);
            this.panelBicycle.Controls.Add(this.lblLoginMessage);
            this.panelBicycle.Controls.Add(this.btnBicycleLogout);
            this.panelBicycle.Controls.Add(this.nudStart);
            this.panelBicycle.Controls.Add(this.nudEnd);
            this.panelBicycle.Controls.Add(this.btnCalculate);
            this.panelBicycle.Controls.Add(this.lblTotal);
            this.panelBicycle.Location = new System.Drawing.Point(0, 0);
            this.panelBicycle.Name = "panelBicycle";
            this.panelBicycle.Size = new System.Drawing.Size(560, 450);
            this.panelBicycle.TabIndex = 17;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(176, 275);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(0, 20);
            this.lblDuration.TabIndex = 16;
            // 
            // lblEndDescription
            // 
            this.lblEndDescription.AutoSize = true;
            this.lblEndDescription.Location = new System.Drawing.Point(10, 139);
            this.lblEndDescription.Name = "lblEndDescription";
            this.lblEndDescription.Size = new System.Drawing.Size(145, 20);
            this.lblEndDescription.TabIndex = 15;
            this.lblEndDescription.Text = "Ending Hour (1–24)";
            // 
            // panelMushroom
            // 
            this.panelMushroom.Controls.Add(this.btnMushroomLogout);
            this.panelMushroom.Controls.Add(this.btnRestart);
            this.panelMushroom.Controls.Add(this.lblResult);
            this.panelMushroom.Controls.Add(this.lblQuestion);
            this.panelMushroom.Controls.Add(this.lblTitle);
            this.panelMushroom.Controls.Add(this.btnNo);
            this.panelMushroom.Controls.Add(this.btnYes);
            this.panelMushroom.Location = new System.Drawing.Point(0, 0);
            this.panelMushroom.Name = "panelMushroom";
            this.panelMushroom.Size = new System.Drawing.Size(560, 450);
            this.panelMushroom.TabIndex = 18;
            // 
            // btnMushroomLogout
            // 
            this.btnMushroomLogout.BackColor = System.Drawing.Color.Red;
            this.btnMushroomLogout.ForeColor = System.Drawing.Color.White;
            this.btnMushroomLogout.Location = new System.Drawing.Point(137, 473);
            this.btnMushroomLogout.Name = "btnMushroomLogout";
            this.btnMushroomLogout.Size = new System.Drawing.Size(137, 45);
            this.btnMushroomLogout.TabIndex = 13;
            this.btnMushroomLogout.Text = "Logout";
            this.btnMushroomLogout.UseVisualStyleBackColor = false;
            this.btnMushroomLogout.Visible = false;
            this.btnMushroomLogout.Click += new System.EventHandler(this.btnMushroomLogout_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(227, 404);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(137, 45);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(37, 234);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(547, 42);
            this.lblResult.TabIndex = 11;
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(37, 127);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(547, 60);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Does your mushroom grow in a forest?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(140, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 38);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "MUSHROOM FINDER";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Firebrick;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(366, 303);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(117, 45);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Green;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(116, 318);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(117, 45);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.panelMushroom);
            this.Controls.Add(this.panelBicycle);
            this.Controls.Add(this.panelChoose);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mushroom Finder";
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelChoose.ResumeLayout(false);
            this.panelChoose.PerformLayout();
            this.panelBicycle.ResumeLayout(false);
            this.panelBicycle.PerformLayout();
            this.panelMushroom.ResumeLayout(false);
            this.panelMushroom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBicycleTitle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.Label lblLoginMessage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBicycleLogout;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Button btnChooseLogout;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;
        private System.Windows.Forms.Label lblChooseTitle;
        private System.Windows.Forms.Panel panelBicycle;
        private System.Windows.Forms.Label lblEndDescription;
        private System.Windows.Forms.Panel panelMushroom;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnMushroomLogout;
        private System.Windows.Forms.Label lblDuration;
    }
}

