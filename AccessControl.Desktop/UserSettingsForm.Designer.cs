#nullable disable
namespace AccessControl.Desktop;

partial class UserSettingsForm
{
    private System.ComponentModel.IContainer components = null;
    private CheckBox blockedCheckBox;
    private CheckBox restrictionCheckBox;
    private Label ruleLabel;
    private Label minimumLabel;
    private NumericUpDown minimumNumeric;
    private Label validityLabel;
    private NumericUpDown validityNumeric;
    private Button saveButton;
    private Button cancelButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        blockedCheckBox = new CheckBox();
        restrictionCheckBox = new CheckBox();
        ruleLabel = new Label();
        minimumLabel = new Label();
        minimumNumeric = new NumericUpDown();
        validityLabel = new Label();
        validityNumeric = new NumericUpDown();
        saveButton = new Button();
        cancelButton = new Button();
        ((System.ComponentModel.ISupportInitialize)minimumNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)validityNumeric).BeginInit();
        SuspendLayout();
        // 
        // blockedCheckBox
        // 
        blockedCheckBox.AutoSize = true;
        blockedCheckBox.Location = new Point(20, 20);
        blockedCheckBox.Name = "blockedCheckBox";
        blockedCheckBox.Size = new Size(325, 32);
        blockedCheckBox.TabIndex = 0;
        blockedCheckBox.Text = "Учётная запись заблокирована";
        blockedCheckBox.UseVisualStyleBackColor = true;
        // 
        // restrictionCheckBox
        // 
        restrictionCheckBox.AutoSize = true;
        restrictionCheckBox.Location = new Point(20, 55);
        restrictionCheckBox.Name = "restrictionCheckBox";
        restrictionCheckBox.Size = new Size(253, 32);
        restrictionCheckBox.TabIndex = 1;
        restrictionCheckBox.Text = "Включить ограничение";
        restrictionCheckBox.UseVisualStyleBackColor = true;
        // 
        // ruleLabel
        // 
        ruleLabel.Location = new Point(20, 90);
        ruleLabel.Name = "ruleLabel";
        ruleLabel.Size = new Size(460, 37);
        ruleLabel.TabIndex = 2;
        ruleLabel.Text = "Цифра, знак препинания, цифра и т. д.";
        // 
        // minimumLabel
        // 
        minimumLabel.AutoSize = true;
        minimumLabel.Location = new Point(20, 145);
        minimumLabel.Name = "minimumLabel";
        minimumLabel.Size = new Size(276, 28);
        minimumLabel.TabIndex = 3;
        minimumLabel.Text = "Минимальная длина пароля";
        // 
        // minimumNumeric
        // 
        minimumNumeric.Location = new Point(424, 143);
        minimumNumeric.Name = "minimumNumeric";
        minimumNumeric.Size = new Size(100, 34);
        minimumNumeric.TabIndex = 4;
        // 
        // validityLabel
        // 
        validityLabel.AutoSize = true;
        validityLabel.Location = new Point(20, 185);
        validityLabel.Name = "validityLabel";
        validityLabel.Size = new Size(398, 28);
        validityLabel.TabIndex = 5;
        validityLabel.Text = "Срок действия в месяцах (0 — бессрочно)";
        // 
        // validityNumeric
        // 
        validityNumeric.Location = new Point(424, 183);
        validityNumeric.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        validityNumeric.Name = "validityNumeric";
        validityNumeric.Size = new Size(100, 34);
        validityNumeric.TabIndex = 6;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(258, 233);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(130, 37);
        saveButton.TabIndex = 7;
        saveButton.Text = "Сохранить";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += SaveButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(394, 233);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(130, 37);
        cancelButton.TabIndex = 8;
        cancelButton.Text = "Отмена";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // UserSettingsForm
        // 
        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(539, 279);
        Controls.Add(cancelButton);
        Controls.Add(saveButton);
        Controls.Add(validityNumeric);
        Controls.Add(validityLabel);
        Controls.Add(minimumNumeric);
        Controls.Add(minimumLabel);
        Controls.Add(ruleLabel);
        Controls.Add(restrictionCheckBox);
        Controls.Add(blockedCheckBox);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "UserSettingsForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Параметры пользователя";
        ((System.ComponentModel.ISupportInitialize)minimumNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)validityNumeric).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
