namespace connect_mysql
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.btn_disc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tm_time = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.tt_help = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(91, 13);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(100, 20);
            this.txt_host.TabIndex = 4;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(91, 39);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(100, 20);
            this.txt_db.TabIndex = 5;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(91, 65);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 6;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(91, 91);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 7;
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(12, 117);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(75, 23);
            this.btn_conn.TabIndex = 8;
            this.btn_conn.Text = "Conn";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.Btn_conn_Click);
            // 
            // btn_disc
            // 
            this.btn_disc.Location = new System.Drawing.Point(116, 117);
            this.btn_disc.Name = "btn_disc";
            this.btn_disc.Size = new System.Drawing.Size(75, 23);
            this.btn_disc.TabIndex = 9;
            this.btn_disc.Text = "Disc";
            this.btn_disc.UseVisualStyleBackColor = true;
            this.btn_disc.Click += new System.EventHandler(this.Btn_disc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(116, 146);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // tm_time
            // 
            this.tm_time.Enabled = true;
            this.tm_time.Interval = 1000;
            this.tm_time.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(28, 151);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(61, 13);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "HH:MM:SS";
            // 
            // tt_help
            // 
            this.tt_help.AutomaticDelay = 100;
            this.tt_help.IsBalloon = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 181);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_disc);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 220);
            this.MinimumSize = new System.Drawing.Size(220, 220);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.Button btn_disc;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer tm_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ToolTip tt_help;
    }
}