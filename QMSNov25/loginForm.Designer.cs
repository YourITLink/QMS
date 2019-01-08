namespace QMS
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.UsernameO = new System.Windows.Forms.TextBox();
            this.PasswordO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusInfo = new System.Windows.Forms.StatusBarPanel();
            this.statusTime = new System.Windows.Forms.StatusBarPanel();
            this.statusDate = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.UsernameO);
            this.groupBox1.Controls.Add(this.PasswordO);
            this.groupBox1.Location = new System.Drawing.Point(165, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 195);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.metroButton2_MouseHover);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(333, 151);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 28);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseLeave += new System.EventHandler(this.UsernameO_Leave);
            this.loginButton.MouseHover += new System.EventHandler(this.metroButton1_MouseHover);
            // 
            // UsernameO
            // 
            this.UsernameO.BackColor = System.Drawing.Color.White;
            this.UsernameO.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UsernameO.Location = new System.Drawing.Point(115, 45);
            this.UsernameO.Name = "UsernameO";
            this.UsernameO.Size = new System.Drawing.Size(227, 27);
            this.UsernameO.TabIndex = 0;
            this.UsernameO.Text = "Craig";
            this.UsernameO.Enter += new System.EventHandler(this.UsernameO_Enter);
            this.UsernameO.Leave += new System.EventHandler(this.UsernameO_Leave);
            // 
            // PasswordO
            // 
            this.PasswordO.BackColor = System.Drawing.Color.White;
            this.PasswordO.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PasswordO.Location = new System.Drawing.Point(115, 88);
            this.PasswordO.MaxLength = 20;
            this.PasswordO.Name = "PasswordO";
            this.PasswordO.PasswordChar = '*';
            this.PasswordO.Size = new System.Drawing.Size(227, 27);
            this.PasswordO.TabIndex = 1;
            this.PasswordO.Text = "Matrix_4390";
            this.PasswordO.Enter += new System.EventHandler(this.PasswordO_Enter);
            this.PasswordO.Leave += new System.EventHandler(this.PasswordO_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 9;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 376);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusInfo,
            this.statusTime,
            this.statusDate});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(826, 24);
            this.statusBar1.TabIndex = 58;
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Width = 600;
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            // 
            // statusDate
            // 
            this.statusDate.Name = "statusDate";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 400);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | QSync by Your IT Link";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox PasswordO;
        private System.Windows.Forms.TextBox UsernameO;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusInfo;
        private System.Windows.Forms.StatusBarPanel statusTime;
        private System.Windows.Forms.StatusBarPanel statusDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}