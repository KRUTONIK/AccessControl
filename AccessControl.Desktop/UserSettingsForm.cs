using AccessControl.Core;

namespace AccessControl.Desktop;

public partial class UserSettingsForm : Form
{
    private readonly UserService? service;
    private readonly UserAccount? user;

    public UserSettingsForm() => InitializeComponent();

    public UserSettingsForm(UserService service, UserAccount user) : this()
    {
        this.service = service;
        this.user = user;
        Text = "Параметры: " + user.Name;
        blockedCheckBox.Checked = user.IsBlocked;
        blockedCheckBox.Enabled = !user.IsAdmin;
        restrictionCheckBox.Checked = user.UsePasswordRestriction;
        minimumNumeric.Value = user.MinimumPasswordLength;
        validityNumeric.Value = user.PasswordValidityMonths;
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        if (service is null || user is null) return;

        try
        {
            service.UpdateUser(user, blockedCheckBox.Checked, restrictionCheckBox.Checked,
                (int)minimumNumeric.Value, (int)validityNumeric.Value);
            DialogResult = DialogResult.OK;
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Параметры пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
