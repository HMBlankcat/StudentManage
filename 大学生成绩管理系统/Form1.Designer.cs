
namespace 大学生课程学习管理与成绩评价系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelAccount = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TBaccount = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.LabelUsertype = new System.Windows.Forms.Label();
            this.CBUserType = new System.Windows.Forms.ComboBox();
            this.ButtonReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("阿里妈妈东方大楷", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Blue;
            this.LabelTitle.Location = new System.Drawing.Point(108, 64);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(596, 44);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "大学生课程学习管理与成绩评价系统";
            this.LabelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelAccount
            // 
            this.LabelAccount.AutoSize = true;
            this.LabelAccount.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAccount.Location = new System.Drawing.Point(178, 144);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(144, 34);
            this.LabelAccount.TabIndex = 1;
            this.LabelAccount.Text = "用 户 名 ：";
            this.LabelAccount.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.Location = new System.Drawing.Point(178, 209);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(148, 34);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "密       码：";
            // 
            // TBaccount
            // 
            this.TBaccount.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBaccount.Location = new System.Drawing.Point(328, 144);
            this.TBaccount.Name = "TBaccount";
            this.TBaccount.Size = new System.Drawing.Size(283, 39);
            this.TBaccount.TabIndex = 3;
            this.TBaccount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBpassword.Location = new System.Drawing.Point(328, 209);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(283, 35);
            this.TBpassword.TabIndex = 4;
            this.TBpassword.TextChanged += new System.EventHandler(this.TBpassword_TextChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Ivory;
            this.ButtonLogin.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLogin.Location = new System.Drawing.Point(341, 349);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(151, 61);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "登录";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Ivory;
            this.buttonCancel.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(567, 349);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 61);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LabelUsertype
            // 
            this.LabelUsertype.AutoSize = true;
            this.LabelUsertype.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelUsertype.Location = new System.Drawing.Point(178, 271);
            this.LabelUsertype.Name = "LabelUsertype";
            this.LabelUsertype.Size = new System.Drawing.Size(148, 34);
            this.LabelUsertype.TabIndex = 7;
            this.LabelUsertype.Text = "用户类型：";
            // 
            // CBUserType
            // 
            this.CBUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUserType.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBUserType.FormattingEnabled = true;
            this.CBUserType.Location = new System.Drawing.Point(328, 271);
            this.CBUserType.Name = "CBUserType";
            this.CBUserType.Size = new System.Drawing.Size(283, 42);
            this.CBUserType.TabIndex = 8;
            this.CBUserType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ButtonReg
            // 
            this.ButtonReg.BackColor = System.Drawing.Color.Ivory;
            this.ButtonReg.Font = new System.Drawing.Font("阿里妈妈东方大楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonReg.Location = new System.Drawing.Point(102, 349);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(151, 61);
            this.ButtonReg.TabIndex = 9;
            this.ButtonReg.Text = "注册";
            this.ButtonReg.UseVisualStyleBackColor = false;
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReg);
            this.Controls.Add(this.CBUserType);
            this.Controls.Add(this.LabelUsertype);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBaccount);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelAccount);
            this.Controls.Add(this.LabelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelAccount;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TBaccount;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label LabelUsertype;
        private System.Windows.Forms.ComboBox CBUserType;
        private System.Windows.Forms.Button ButtonReg;
    }
}

