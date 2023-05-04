namespace Lr29
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.configureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(113, 33);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(15, 60);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(328, 307);
            this.chatTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(350, 31);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Вхід";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(431, 31);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Вихід";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(268, 373);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 53);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Надіслати";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(15, 373);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(247, 53);
            this.messageTextBox.TabIndex = 5;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(383, 281);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(88, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Налаштування";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(350, 158);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(156, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(350, 209);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(156, 20);
            this.portTextBox.TabIndex = 8;
            // 
            // configureButton
            // 
            this.configureButton.Location = new System.Drawing.Point(389, 239);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(75, 23);
            this.configureButton.TabIndex = 9;
            this.configureButton.Text = "ОК";
            this.configureButton.UseVisualStyleBackColor = true;
            this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введіть ваше ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введіть вашу адресу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введіть ваш порт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configureButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 29";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button configureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

