#nullable disable
namespace AccessControl.Desktop;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private Label nameLabel;
    private TextBox nameTextBox;
    private Label passwordLabel;
    private TextBox passwordTextBox;
    private Button loginButton;
    private Button cancelButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        nameLabel = new Label();
        nameTextBox = new TextBox();
        passwordLabel = new Label();
        passwordTextBox = new TextBox();
        loginButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(20, 20);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(182, 28);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Имя пользователя";
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(20, 51);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(360, 34);
        nameTextBox.TabIndex = 1;
        nameTextBox.Text = "ADMIN";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(20, 88);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(81, 28);
        passwordLabel.TabIndex = 2;
        passwordLabel.Text = "Пароль";
        // 
        // passwordTextBox
        // 
        passwordTextBox.Location = new Point(20, 119);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.Size = new Size(360, 34);
        passwordTextBox.TabIndex = 3;
        // 
        // loginButton
        // 
        loginButton.Location = new Point(164, 179);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(105, 42);
        loginButton.TabIndex = 4;
        loginButton.Text = "Войти";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += LoginButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(275, 179);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(105, 42);
        cancelButton.TabIndex = 5;
        cancelButton.Text = "Выход";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // LoginForm
        // 
        AcceptButton = loginButton;
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(400, 233);
        Controls.Add(cancelButton);
        Controls.Add(loginButton);
        Controls.Add(passwordTextBox);
        Controls.Add(passwordLabel);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }
}
