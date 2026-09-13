#nullable disable
namespace AccessControl.Desktop;

partial class PasswordForm
{
    private System.ComponentModel.IContainer components = null;
    private Label restrictionLabel;
    private Label oldPasswordLabel;
    private TextBox oldPasswordTextBox;
    private Label newPasswordLabel;
    private TextBox newPasswordTextBox;
    private Label confirmLabel;
    private TextBox confirmTextBox;
    private Button okButton;
    private Button cancelButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        restrictionLabel = new Label();
        oldPasswordLabel = new Label();
        oldPasswordTextBox = new TextBox();
        newPasswordLabel = new Label();
        newPasswordTextBox = new TextBox();
        confirmLabel = new Label();
        confirmTextBox = new TextBox();
        okButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // restrictionLabel
        // 
        restrictionLabel.Location = new Point(20, 15);
        restrictionLabel.Name = "restrictionLabel";
        restrictionLabel.Size = new Size(460, 45);
        restrictionLabel.TabIndex = 0;
        restrictionLabel.Text = "Ограничение пароля";
        // 
        // oldPasswordLabel
        // 
        oldPasswordLabel.AutoSize = true;
        oldPasswordLabel.Location = new Point(20, 60);
        oldPasswordLabel.Name = "oldPasswordLabel";
        oldPasswordLabel.Size = new Size(152, 28);
        oldPasswordLabel.TabIndex = 1;
        oldPasswordLabel.Text = "Старый пароль";
        // 
        // oldPasswordTextBox
        // 
        oldPasswordTextBox.Location = new Point(20, 91);
        oldPasswordTextBox.Name = "oldPasswordTextBox";
        oldPasswordTextBox.PasswordChar = '*';
        oldPasswordTextBox.Size = new Size(460, 34);
        oldPasswordTextBox.TabIndex = 2;
        // 
        // newPasswordLabel
        // 
        newPasswordLabel.AutoSize = true;
        newPasswordLabel.Location = new Point(20, 128);
        newPasswordLabel.Name = "newPasswordLabel";
        newPasswordLabel.Size = new Size(147, 28);
        newPasswordLabel.TabIndex = 3;
        newPasswordLabel.Text = "Новый пароль";
        // 
        // newPasswordTextBox
        // 
        newPasswordTextBox.Location = new Point(20, 159);
        newPasswordTextBox.Name = "newPasswordTextBox";
        newPasswordTextBox.PasswordChar = '*';
        newPasswordTextBox.Size = new Size(460, 34);
        newPasswordTextBox.TabIndex = 4;
        // 
        // confirmLabel
        // 
        confirmLabel.AutoSize = true;
        confirmLabel.Location = new Point(20, 196);
        confirmLabel.Name = "confirmLabel";
        confirmLabel.Size = new Size(249, 28);
        confirmLabel.TabIndex = 5;
        confirmLabel.Text = "Повторите новый пароль";
        // 
        // confirmTextBox
        // 
        confirmTextBox.Location = new Point(20, 227);
        confirmTextBox.Name = "confirmTextBox";
        confirmTextBox.PasswordChar = '*';
        confirmTextBox.Size = new Size(460, 34);
        confirmTextBox.TabIndex = 6;
        // 
        // okButton
        // 
        okButton.Location = new Point(208, 275);
        okButton.Name = "okButton";
        okButton.Size = new Size(133, 40);
        okButton.TabIndex = 7;
        okButton.Text = "Сохранить";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += OkButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(347, 275);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(133, 40);
        cancelButton.TabIndex = 8;
        cancelButton.Text = "Отмена";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // PasswordForm
        // 
        AcceptButton = okButton;
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(500, 333);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(confirmTextBox);
        Controls.Add(confirmLabel);
        Controls.Add(newPasswordTextBox);
        Controls.Add(newPasswordLabel);
        Controls.Add(oldPasswordTextBox);
        Controls.Add(oldPasswordLabel);
        Controls.Add(restrictionLabel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PasswordForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Смена пароля";
        ResumeLayout(false);
        PerformLayout();
    }
}
