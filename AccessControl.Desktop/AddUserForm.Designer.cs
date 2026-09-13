#nullable disable
namespace AccessControl.Desktop;

partial class AddUserForm
{
    private System.ComponentModel.IContainer components = null;
    private Label nameLabel;
    private TextBox nameTextBox;
    private Button addButton;
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
        addButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(20, 9);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(254, 28);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Имя нового пользователя";
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(20, 48);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(360, 34);
        nameTextBox.TabIndex = 1;
        // 
        // addButton
        // 
        addButton.Location = new Point(106, 88);
        addButton.Name = "addButton";
        addButton.Size = new Size(134, 44);
        addButton.TabIndex = 2;
        addButton.Text = "Добавить";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += AddButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(246, 88);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(134, 44);
        cancelButton.TabIndex = 3;
        cancelButton.Text = "Отмена";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // AddUserForm
        // 
        AcceptButton = addButton;
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(400, 150);
        Controls.Add(cancelButton);
        Controls.Add(addButton);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddUserForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Новый пользователь";
        ResumeLayout(false);
        PerformLayout();
    }
}
