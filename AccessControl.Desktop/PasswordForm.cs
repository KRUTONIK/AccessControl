using AccessControl.Core;

namespace AccessControl.Desktop;

public partial class PasswordForm : Form
{
    private readonly UserService? service;

    public PasswordForm() => InitializeComponent();

    public PasswordForm(UserService service, bool required) : this()
    {
        this.service = service;
        UserAccount user = service.CurrentUser!;
        oldPasswordTextBox.Enabled = user.IsPasswordSet;
        cancelButton.Text = required ? "Выход" : "Отмена";
        restrictionLabel.Text = user.UsePasswordRestriction
            ? PasswordHelper.VariantRule
            : "Ограничение варианта отключено.";
    }

    private void OkButton_Click(object? sender, EventArgs e)
    {
        if (service is null) return;

        try
        {
            service.ChangePassword(oldPasswordTextBox.Text, newPasswordTextBox.Text, confirmTextBox.Text);
            DialogResult = DialogResult.OK;
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
