using AccessControl.Core;

namespace AccessControl.Desktop;

public partial class LoginForm : Form
{
    private readonly UserService? service;

    public LoginForm() => InitializeComponent();
    public LoginForm(UserService service) : this() => this.service = service;

    private void LoginButton_Click(object? sender, EventArgs e)
    {
        if (service is null) return;

        LoginResult result = service.Login(nameTextBox.Text, passwordTextBox.Text);
        passwordTextBox.Clear();

        if (result == LoginResult.Success)
        {
            DialogResult = DialogResult.OK;
            return;
        }

        string message = result switch
        {
            LoginResult.UserNotFound => "Пользователь не найден.",
            LoginResult.UserBlocked => "Учётная запись заблокирована.",
            LoginResult.WrongPassword => "Неверный пароль.",
            _ => "Пароль введён неверно три раза. Программа будет закрыта."
        };
        MessageBox.Show(message, "Вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        if (result == LoginResult.AttemptsExceeded)
            DialogResult = DialogResult.Cancel;
    }
}
