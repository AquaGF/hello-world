namespace rex2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.UserImageMM = new System.Windows.Forms.PictureBox();
            this.MathTr = new System.Windows.Forms.Label();
            this.MemoryTr = new System.Windows.Forms.Label();
            this.MathPanel = new System.Windows.Forms.Panel();
            this.ToMenuLink = new System.Windows.Forms.Label();
            this.MathChild = new System.Windows.Forms.Panel();
            this.GoMath = new System.Windows.Forms.Button();
            this.MathMain = new System.Windows.Forms.Panel();
            this.UserAnswer = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.MemoryPanel = new System.Windows.Forms.Panel();
            this.ToMenu2 = new System.Windows.Forms.Label();
            this.MemChild = new System.Windows.Forms.Panel();
            this.GoMem = new System.Windows.Forms.Button();
            this.MemMain = new System.Windows.Forms.Panel();
            this.HidenFromUser = new System.Windows.Forms.MaskedTextBox();
            this.HidenNum = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.ReturnFromAccount = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImageMM)).BeginInit();
            this.MathPanel.SuspendLayout();
            this.MathChild.SuspendLayout();
            this.MathMain.SuspendLayout();
            this.MemoryPanel.SuspendLayout();
            this.MemChild.SuspendLayout();
            this.MemMain.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.UserImageMM);
            this.MenuPanel.Controls.Add(this.MathTr);
            this.MenuPanel.Controls.Add(this.MemoryTr);
            this.MenuPanel.Location = new System.Drawing.Point(264, 73);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(222, 270);
            this.MenuPanel.TabIndex = 0;
            // 
            // UserImageMM
            // 
            this.UserImageMM.BackColor = System.Drawing.SystemColors.Control;
            this.UserImageMM.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserImageMM.Image = global::rex2.Properties.Resources.gender_neutral_user;
            this.UserImageMM.Location = new System.Drawing.Point(80, 216);
            this.UserImageMM.Name = "UserImageMM";
            this.UserImageMM.Size = new System.Drawing.Size(59, 54);
            this.UserImageMM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImageMM.TabIndex = 1;
            this.UserImageMM.TabStop = false;
            this.UserImageMM.Click += new System.EventHandler(this.UserImageMM_Click);
            this.UserImageMM.MouseEnter += new System.EventHandler(this.UserImgColorChange);
            this.UserImageMM.MouseLeave += new System.EventHandler(this.UserImgColorChange);
            // 
            // MathTr
            // 
            this.MathTr.AutoSize = true;
            this.MathTr.Font = new System.Drawing.Font("Tw Cen MT", 17.25F, System.Drawing.FontStyle.Bold);
            this.MathTr.Location = new System.Drawing.Point(75, 44);
            this.MathTr.Name = "MathTr";
            this.MathTr.Size = new System.Drawing.Size(144, 27);
            this.MathTr.TabIndex = 0;
            this.MathTr.Text = "Math Training";
            this.MathTr.Click += new System.EventHandler(this.MathTr_Click);
            this.MathTr.MouseEnter += new System.EventHandler(this.ChangeLinkColor);
            this.MathTr.MouseLeave += new System.EventHandler(this.ChangeLinkColor);
            // 
            // MemoryTr
            // 
            this.MemoryTr.AutoSize = true;
            this.MemoryTr.Font = new System.Drawing.Font("Tw Cen MT", 17.25F, System.Drawing.FontStyle.Bold);
            this.MemoryTr.Location = new System.Drawing.Point(45, 71);
            this.MemoryTr.Name = "MemoryTr";
            this.MemoryTr.Size = new System.Drawing.Size(174, 27);
            this.MemoryTr.TabIndex = 0;
            this.MemoryTr.Text = "Memory Training";
            this.MemoryTr.Click += new System.EventHandler(this.MemoryTr_Click);
            this.MemoryTr.MouseEnter += new System.EventHandler(this.ChangeLinkColor);
            this.MemoryTr.MouseLeave += new System.EventHandler(this.ChangeLinkColor);
            // 
            // MathPanel
            // 
            this.MathPanel.Controls.Add(this.ToMenuLink);
            this.MathPanel.Controls.Add(this.MathChild);
            this.MathPanel.Controls.Add(this.MathMain);
            this.MathPanel.Location = new System.Drawing.Point(36, 73);
            this.MathPanel.Name = "MathPanel";
            this.MathPanel.Size = new System.Drawing.Size(222, 270);
            this.MathPanel.TabIndex = 1;
            this.MathPanel.Visible = false;
            // 
            // ToMenuLink
            // 
            this.ToMenuLink.AutoSize = true;
            this.ToMenuLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ToMenuLink.Location = new System.Drawing.Point(190, 0);
            this.ToMenuLink.Name = "ToMenuLink";
            this.ToMenuLink.Size = new System.Drawing.Size(32, 24);
            this.ToMenuLink.TabIndex = 2;
            this.ToMenuLink.Text = ">>";
            this.ToMenuLink.Click += new System.EventHandler(this.ToMenuLink_Click);
            // 
            // MathChild
            // 
            this.MathChild.Controls.Add(this.GoMath);
            this.MathChild.Location = new System.Drawing.Point(0, 141);
            this.MathChild.Name = "MathChild";
            this.MathChild.Size = new System.Drawing.Size(222, 100);
            this.MathChild.TabIndex = 0;
            // 
            // GoMath
            // 
            this.GoMath.Location = new System.Drawing.Point(70, 10);
            this.GoMath.Name = "GoMath";
            this.GoMath.Size = new System.Drawing.Size(78, 24);
            this.GoMath.TabIndex = 0;
            this.GoMath.Text = "button1";
            this.GoMath.UseVisualStyleBackColor = true;
            this.GoMath.Click += new System.EventHandler(this.GoMath_Click);
            // 
            // MathMain
            // 
            this.MathMain.Controls.Add(this.UserAnswer);
            this.MathMain.Controls.Add(this.Question);
            this.MathMain.Controls.Add(this.TimerLabel);
            this.MathMain.Location = new System.Drawing.Point(0, 0);
            this.MathMain.Name = "MathMain";
            this.MathMain.Size = new System.Drawing.Size(222, 114);
            this.MathMain.TabIndex = 0;
            this.MathMain.Visible = false;
            // 
            // UserAnswer
            // 
            this.UserAnswer.Font = new System.Drawing.Font("Tw Cen MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAnswer.Location = new System.Drawing.Point(57, 55);
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.Size = new System.Drawing.Size(100, 33);
            this.UserAnswer.TabIndex = 1;
            this.UserAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAnswer_KeyPress);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Tw Cen MT", 17.75F, System.Drawing.FontStyle.Bold);
            this.Question.Location = new System.Drawing.Point(74, 24);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(66, 28);
            this.Question.TabIndex = 1;
            this.Question.Text = "0 + 0";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(78, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(59, 24);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "03:00";
            // 
            // MemoryPanel
            // 
            this.MemoryPanel.Controls.Add(this.ToMenu2);
            this.MemoryPanel.Controls.Add(this.MemChild);
            this.MemoryPanel.Controls.Add(this.MemMain);
            this.MemoryPanel.Location = new System.Drawing.Point(492, 73);
            this.MemoryPanel.Name = "MemoryPanel";
            this.MemoryPanel.Size = new System.Drawing.Size(222, 270);
            this.MemoryPanel.TabIndex = 1;
            this.MemoryPanel.Visible = false;
            // 
            // ToMenu2
            // 
            this.ToMenu2.AutoSize = true;
            this.ToMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ToMenu2.Location = new System.Drawing.Point(190, 0);
            this.ToMenu2.Name = "ToMenu2";
            this.ToMenu2.Size = new System.Drawing.Size(32, 24);
            this.ToMenu2.TabIndex = 2;
            this.ToMenu2.Text = ">>";
            this.ToMenu2.Click += new System.EventHandler(this.ToMenuLink_Click);
            // 
            // MemChild
            // 
            this.MemChild.Controls.Add(this.GoMem);
            this.MemChild.Location = new System.Drawing.Point(0, 141);
            this.MemChild.Name = "MemChild";
            this.MemChild.Size = new System.Drawing.Size(222, 100);
            this.MemChild.TabIndex = 0;
            // 
            // GoMem
            // 
            this.GoMem.Location = new System.Drawing.Point(72, 10);
            this.GoMem.Name = "GoMem";
            this.GoMem.Size = new System.Drawing.Size(78, 24);
            this.GoMem.TabIndex = 0;
            this.GoMem.Text = "button1";
            this.GoMem.UseVisualStyleBackColor = true;
            this.GoMem.Click += new System.EventHandler(this.GoMem_Click);
            // 
            // MemMain
            // 
            this.MemMain.Controls.Add(this.HidenFromUser);
            this.MemMain.Controls.Add(this.HidenNum);
            this.MemMain.Location = new System.Drawing.Point(0, 0);
            this.MemMain.Name = "MemMain";
            this.MemMain.Size = new System.Drawing.Size(222, 114);
            this.MemMain.TabIndex = 0;
            // 
            // HidenFromUser
            // 
            this.HidenFromUser.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidenFromUser.Location = new System.Drawing.Point(76, 44);
            this.HidenFromUser.Name = "HidenFromUser";
            this.HidenFromUser.Size = new System.Drawing.Size(60, 30);
            this.HidenFromUser.TabIndex = 1;
            this.HidenFromUser.Text = "0000";
            this.HidenFromUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HidenFromUser.ValidatingType = typeof(int);
            this.HidenFromUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HidenFromUser_KeyPress);
            // 
            // HidenNum
            // 
            this.HidenNum.AutoSize = true;
            this.HidenNum.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidenNum.Location = new System.Drawing.Point(72, 10);
            this.HidenNum.Name = "HidenNum";
            this.HidenNum.Size = new System.Drawing.Size(72, 24);
            this.HidenNum.TabIndex = 0;
            this.HidenNum.Text = "0 0 0 0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.ReturnFromAccount);
            this.AccountPanel.Location = new System.Drawing.Point(264, 349);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(222, 270);
            this.AccountPanel.TabIndex = 0;
            this.AccountPanel.Visible = false;
            // 
            // ReturnFromAccount
            // 
            this.ReturnFromAccount.AutoSize = true;
            this.ReturnFromAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ReturnFromAccount.Location = new System.Drawing.Point(187, 0);
            this.ReturnFromAccount.Name = "ReturnFromAccount";
            this.ReturnFromAccount.Size = new System.Drawing.Size(32, 24);
            this.ReturnFromAccount.TabIndex = 2;
            this.ReturnFromAccount.Text = ">>";
            this.ReturnFromAccount.Click += new System.EventHandler(this.ToMenuLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.MemoryPanel);
            this.Controls.Add(this.MathPanel);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImageMM)).EndInit();
            this.MathPanel.ResumeLayout(false);
            this.MathPanel.PerformLayout();
            this.MathChild.ResumeLayout(false);
            this.MathMain.ResumeLayout(false);
            this.MathMain.PerformLayout();
            this.MemoryPanel.ResumeLayout(false);
            this.MemoryPanel.PerformLayout();
            this.MemChild.ResumeLayout(false);
            this.MemMain.ResumeLayout(false);
            this.MemMain.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label MemoryTr;
        private System.Windows.Forms.Label MathTr;
        private System.Windows.Forms.Panel MathPanel;
        private System.Windows.Forms.Panel MemoryPanel;
        private System.Windows.Forms.Panel MathChild;
        private System.Windows.Forms.Panel MathMain;
        private System.Windows.Forms.Panel MemChild;
        private System.Windows.Forms.Panel MemMain;
        private System.Windows.Forms.Label ToMenuLink;
        private System.Windows.Forms.Label ToMenu2;
        private System.Windows.Forms.Button GoMath;
        private System.Windows.Forms.Button GoMem;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label HidenNum;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox UserAnswer;
        private System.Windows.Forms.MaskedTextBox HidenFromUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox UserImageMM;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Label ReturnFromAccount;
    }
}

