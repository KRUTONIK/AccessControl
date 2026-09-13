#nullable disable
namespace AccessControl.Desktop;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private MenuStrip mainMenu;
    private ToolStripMenuItem accountMenu;
    private ToolStripMenuItem changePasswordMenu;
    private ToolStripMenuItem exitMenu;
    private ToolStripMenuItem usersMenu;
    private ToolStripMenuItem addUserMenu;
    private ToolStripMenuItem settingsMenu;
    private ToolStripMenuItem helpMenu;
    private ToolStripMenuItem aboutMenu;
    private Label userLabel;
    private Button addButton;
    private Button settingsButton;
    private Button passwordButton;
    private DataGridView usersGrid;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        mainMenu = new MenuStrip();
        accountMenu = new ToolStripMenuItem();
        changePasswordMenu = new ToolStripMenuItem();
        exitMenu = new ToolStripMenuItem();
        usersMenu = new ToolStripMenuItem();
        addUserMenu = new ToolStripMenuItem();
        settingsMenu = new ToolStripMenuItem();
        helpMenu = new ToolStripMenuItem();
        aboutMenu = new ToolStripMenuItem();
        userLabel = new Label();
        addButton = new Button();
        settingsButton = new Button();
        passwordButton = new Button();
        usersGrid = new DataGridView();
        mainMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)usersGrid).BeginInit();
        SuspendLayout();
        // 
        // mainMenu
        // 
        mainMenu.ImageScalingSize = new Size(24, 24);
        mainMenu.Items.AddRange(new ToolStripItem[] { accountMenu, usersMenu, helpMenu });
        mainMenu.Location = new Point(0, 0);
        mainMenu.Name = "mainMenu";
        mainMenu.Size = new Size(780, 33);
        mainMenu.TabIndex = 0;
        // 
        // accountMenu
        // 
        accountMenu.DropDownItems.AddRange(new ToolStripItem[] { changePasswordMenu, exitMenu });
        accountMenu.Name = "accountMenu";
        accountMenu.Size = new Size(151, 29);
        accountMenu.Text = "Учётная запись";
        // 
        // changePasswordMenu
        // 
        changePasswordMenu.Name = "changePasswordMenu";
        changePasswordMenu.Size = new Size(247, 34);
        changePasswordMenu.Text = "Сменить пароль";
        changePasswordMenu.Click += ChangePassword_Click;
        // 
        // exitMenu
        // 
        exitMenu.Name = "exitMenu";
        exitMenu.Size = new Size(247, 34);
        exitMenu.Text = "Выход";
        exitMenu.Click += Exit_Click;
        // 
        // usersMenu
        // 
        usersMenu.DropDownItems.AddRange(new ToolStripItem[] { addUserMenu, settingsMenu });
        usersMenu.Name = "usersMenu";
        usersMenu.Size = new Size(143, 29);
        usersMenu.Text = "Пользователи";
        // 
        // addUserMenu
        // 
        addUserMenu.Name = "addUserMenu";
        addUserMenu.Size = new Size(209, 34);
        addUserMenu.Text = "Добавить";
        addUserMenu.Click += AddUser_Click;
        // 
        // settingsMenu
        // 
        settingsMenu.Name = "settingsMenu";
        settingsMenu.Size = new Size(209, 34);
        settingsMenu.Text = "Параметры";
        settingsMenu.Click += Settings_Click;
        // 
        // helpMenu
        // 
        helpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutMenu });
        helpMenu.Name = "helpMenu";
        helpMenu.Size = new Size(97, 29);
        helpMenu.Text = "Справка";
        // 
        // aboutMenu
        // 
        aboutMenu.Name = "aboutMenu";
        aboutMenu.Size = new Size(227, 34);
        aboutMenu.Text = "О программе";
        aboutMenu.Click += About_Click;
        // 
        // userLabel
        // 
        userLabel.AutoSize = true;
        userLabel.Location = new Point(20, 33);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(140, 28);
        userLabel.TabIndex = 1;
        userLabel.Text = "Пользователь";
        // 
        // addButton
        // 
        addButton.Location = new Point(20, 64);
        addButton.Name = "addButton";
        addButton.Size = new Size(150, 52);
        addButton.TabIndex = 2;
        addButton.Text = "Добавить";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += AddUser_Click;
        // 
        // settingsButton
        // 
        settingsButton.Location = new Point(176, 64);
        settingsButton.Name = "settingsButton";
        settingsButton.Size = new Size(150, 52);
        settingsButton.TabIndex = 3;
        settingsButton.Text = "Параметры";
        settingsButton.UseVisualStyleBackColor = true;
        settingsButton.Click += Settings_Click;
        // 
        // passwordButton
        // 
        passwordButton.Location = new Point(332, 64);
        passwordButton.Name = "passwordButton";
        passwordButton.Size = new Size(150, 52);
        passwordButton.TabIndex = 4;
        passwordButton.Text = "Сменить пароль";
        passwordButton.UseVisualStyleBackColor = true;
        passwordButton.Click += ChangePassword_Click;
        // 
        // usersGrid
        // 
        usersGrid.AllowUserToAddRows = false;
        usersGrid.AllowUserToDeleteRows = false;
        usersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        usersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        usersGrid.BackgroundColor = SystemColors.Window;
        usersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        usersGrid.Location = new Point(20, 130);
        usersGrid.MultiSelect = false;
        usersGrid.Name = "usersGrid";
        usersGrid.ReadOnly = true;
        usersGrid.RowHeadersVisible = false;
        usersGrid.RowHeadersWidth = 62;
        usersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        usersGrid.Size = new Size(740, 620);
        usersGrid.TabIndex = 5;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(780, 770);
        Controls.Add(usersGrid);
        Controls.Add(passwordButton);
        Controls.Add(settingsButton);
        Controls.Add(addButton);
        Controls.Add(userLabel);
        Controls.Add(mainMenu);
        Font = new Font("Segoe UI", 10F);
        MainMenuStrip = mainMenu;
        MinimumSize = new Size(650, 400);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Управление доступом";
        mainMenu.ResumeLayout(false);
        mainMenu.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)usersGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
