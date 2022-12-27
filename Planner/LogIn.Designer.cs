namespace Planner
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.clearBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userTbt = new System.Windows.Forms.TextBox();
            this.passwordTbt = new System.Windows.Forms.TextBox();
            this.singinBtn = new System.Windows.Forms.Button();
            this.conpasswordTbt = new System.Windows.Forms.TextBox();
            this.conpasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.Snow;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.clearBtn.Location = new System.Drawing.Point(57, 310);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(194, 40);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.Snow;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.loginBtn.Location = new System.Drawing.Point(57, 263);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(194, 41);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.Transparent;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.userLbl.Location = new System.Drawing.Point(54, 82);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(96, 20);
            this.userLbl.TabIndex = 2;
            this.userLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordLbl.Location = new System.Drawing.Point(54, 137);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(91, 20);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password:";
            // 
            // userTbt
            // 
            this.userTbt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTbt.BackColor = System.Drawing.Color.Snow;
            this.userTbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTbt.Location = new System.Drawing.Point(58, 107);
            this.userTbt.Name = "userTbt";
            this.userTbt.Size = new System.Drawing.Size(240, 26);
            this.userTbt.TabIndex = 4;
            // 
            // passwordTbt
            // 
            this.passwordTbt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTbt.BackColor = System.Drawing.Color.Snow;
            this.passwordTbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTbt.Location = new System.Drawing.Point(57, 162);
            this.passwordTbt.Name = "passwordTbt";
            this.passwordTbt.PasswordChar = '*';
            this.passwordTbt.Size = new System.Drawing.Size(241, 26);
            this.passwordTbt.TabIndex = 5;
            // 
            // singinBtn
            // 
            this.singinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singinBtn.BackColor = System.Drawing.Color.Snow;
            this.singinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singinBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.singinBtn.Location = new System.Drawing.Point(57, 356);
            this.singinBtn.Name = "singinBtn";
            this.singinBtn.Size = new System.Drawing.Size(194, 37);
            this.singinBtn.TabIndex = 6;
            this.singinBtn.Text = "Sing in";
            this.singinBtn.UseVisualStyleBackColor = false;
            this.singinBtn.Click += new System.EventHandler(this.singinBtn_Click);
            // 
            // conpasswordTbt
            // 
            this.conpasswordTbt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conpasswordTbt.BackColor = System.Drawing.Color.Snow;
            this.conpasswordTbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasswordTbt.Location = new System.Drawing.Point(57, 217);
            this.conpasswordTbt.Name = "conpasswordTbt";
            this.conpasswordTbt.PasswordChar = '*';
            this.conpasswordTbt.Size = new System.Drawing.Size(241, 26);
            this.conpasswordTbt.TabIndex = 8;
            this.conpasswordTbt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // conpasswordLbl
            // 
            this.conpasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conpasswordLbl.AutoSize = true;
            this.conpasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.conpasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasswordLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.conpasswordLbl.Location = new System.Drawing.Point(54, 192);
            this.conpasswordLbl.Name = "conpasswordLbl";
            this.conpasswordLbl.Size = new System.Drawing.Size(170, 20);
            this.conpasswordLbl.TabIndex = 7;
            this.conpasswordLbl.Text = "Confirm Passwword:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Planner.Properties.Resources.Wallpaper_County_Flowers_Neutral_1;
            this.ClientSize = new System.Drawing.Size(349, 424);
            this.Controls.Add(this.conpasswordTbt);
            this.Controls.Add(this.conpasswordLbl);
            this.Controls.Add(this.singinBtn);
            this.Controls.Add(this.passwordTbt);
            this.Controls.Add(this.userTbt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.clearBtn);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox userTbt;
        private System.Windows.Forms.TextBox passwordTbt;
        private System.Windows.Forms.Button singinBtn;
        private System.Windows.Forms.TextBox conpasswordTbt;
        private System.Windows.Forms.Label conpasswordLbl;
    }
}