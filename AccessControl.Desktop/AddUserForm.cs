using AccessControl.Core;

namespace AccessControl.Desktop;

public partial class AddUserForm : Form
{
    private readonly UserService? service;

    public AddUserForm() => InitializeComponent();
    public AddUserForm(UserService service) : this() => this.service = service;

    private void AddButton_Click(object? sender, EventArgs e)
    {
        try
        {
            service?.AddUser(nameTextBox.Text);
            DialogResult = DialogResult.OK;
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
