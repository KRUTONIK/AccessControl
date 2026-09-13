using AccessControl.Core;

namespace AccessControl.Desktop;

public partial class MainForm : Form
{
    private readonly UserService? service;

    private sealed class UserRow
    {
        public required string Name { get; init; }
        public required string Blocked { get; init; }
        public required string Restriction { get; init; }
        public required int MinimumPasswordLength { get; init; }
        public required int PasswordValidityMonths { get; init; }
    }

    public MainForm() => InitializeComponent();

    public MainForm(UserService service) : this()
    {
        this.service = service;
        ConfigureUserGrid();
        bool admin = service.CurrentUser!.IsAdmin;
        usersMenu.Visible = admin;
        addButton.Visible = settingsButton.Visible = usersGrid.Visible = admin;

        if (!admin)
        {
            ClientSize = new Size(430, 150);
            MinimumSize = new Size(430, 150);
            passwordButton.Location = new Point(20, 65);
        }

        RefreshUsers();
    }

    private void RefreshUsers()
    {
        if (service is null) return;

        userLabel.Text = $"Пользователь: {service.CurrentUser!.Name}";
        if (!service.CurrentUser.IsAdmin) return;

        usersGrid.DataSource = service.Users.Select(user => new UserRow
        {
            Name = user.Name,
            Blocked = user.IsBlocked ? "Да" : "Нет",
            Restriction = user.UsePasswordRestriction ? "Да" : "Нет",
            MinimumPasswordLength = user.MinimumPasswordLength,
            PasswordValidityMonths = user.PasswordValidityMonths
        }).ToList();

    }

    private void ConfigureUserGrid()
    {
        usersGrid.AutoGenerateColumns = false;
        usersGrid.Columns.Clear();
        usersGrid.Columns.Add(CreateColumn(nameof(UserRow.Name), "Имя пользователя"));
        usersGrid.Columns.Add(CreateColumn(nameof(UserRow.Blocked), "Заблокирован"));
        usersGrid.Columns.Add(CreateColumn(nameof(UserRow.Restriction), "Ограничение"));
        usersGrid.Columns.Add(CreateColumn(nameof(UserRow.MinimumPasswordLength), "Мин. длина"));
        usersGrid.Columns.Add(CreateColumn(nameof(UserRow.PasswordValidityMonths), "Срок, мес."));

        usersGrid.EnableHeadersVisualStyles = false;
        usersGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        usersGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        usersGrid.DefaultCellStyle.BackColor = Color.White;
        usersGrid.DefaultCellStyle.ForeColor = Color.Black;
        usersGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        usersGrid.BackgroundColor = Color.White;
    }

    private static DataGridViewTextBoxColumn CreateColumn(string propertyName, string headerText) =>
        new()
        {
            DataPropertyName = propertyName,
            HeaderText = headerText,
            Name = propertyName,
            SortMode = DataGridViewColumnSortMode.NotSortable
        };

    private void AddUser_Click(object? sender, EventArgs e)
    {
        if (service is null) return;
        using var form = new AddUserForm(service);
        if (form.ShowDialog(this) == DialogResult.OK)
            RefreshUsers();
    }

    private void Settings_Click(object? sender, EventArgs e)
    {
        if (service is null || usersGrid.CurrentRow?.DataBoundItem is not UserRow row) return;
        string name = row.Name;
        UserAccount user = service.Users.Single(u => u.Name == name);
        using var form = new UserSettingsForm(service, user);
        if (form.ShowDialog(this) == DialogResult.OK)
            RefreshUsers();
    }

    private void ChangePassword_Click(object? sender, EventArgs e)
    {
        if (service is null) return;
        using var form = new PasswordForm(service, required: false);
        form.ShowDialog(this);
    }

    private void About_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "Лабораторная работа № 1\n\n" +
            "Автор: Покладов Никита Николаевич\n" +
            "Группа: ПИбд-42\n" +
            "Вариант 11\n\n" +
            "Ограничение: чередование цифр и знаков препинания.\n" +
            "DES-CFB, случайное значение при формировании ключа, MD5.",
            "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Exit_Click(object? sender, EventArgs e) => Close();
}
