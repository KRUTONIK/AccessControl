#nullable disable
namespace AccessControl.Desktop;

partial class PhraseForm
{
    private System.ComponentModel.IContainer components = null;
    private Label phraseLabel;
    private TextBox phraseTextBox;
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
        phraseLabel = new Label();
        phraseTextBox = new TextBox();
        confirmLabel = new Label();
        confirmTextBox = new TextBox();
        okButton = new Button();
        cancelButton = new Button();
        descriptionLabel = new Label();
        SuspendLayout();
        // 
        // phraseLabel
        // 
        phraseLabel.AutoSize = true;
        phraseLabel.Location = new Point(20, 60);
        phraseLabel.Name = "phraseLabel";
        phraseLabel.Size = new Size(173, 28);
        phraseLabel.TabIndex = 1;
        phraseLabel.Text = "Парольная фраза";
        // 
        // phraseTextBox
        // 
        phraseTextBox.Location = new Point(20, 91);
        phraseTextBox.Name = "phraseTextBox";
        phraseTextBox.PasswordChar = '*';
        phraseTextBox.Size = new Size(634, 34);
        phraseTextBox.TabIndex = 2;
        // 
        // confirmLabel
        // 
        confirmLabel.AutoSize = true;
        confirmLabel.Location = new Point(20, 128);
        confirmLabel.Name = "confirmLabel";
        confirmLabel.Size = new Size(281, 28);
        confirmLabel.TabIndex = 3;
        confirmLabel.Text = "Повторите парольную фразу";
        // 
        // confirmTextBox
        // 
        confirmTextBox.Location = new Point(20, 160);
        confirmTextBox.Name = "confirmTextBox";
        confirmTextBox.PasswordChar = '*';
        confirmTextBox.Size = new Size(634, 34);
        confirmTextBox.TabIndex = 4;
        // 
        // okButton
        // 
        okButton.Location = new Point(438, 210);
        okButton.Name = "okButton";
        okButton.Size = new Size(105, 38);
        okButton.TabIndex = 5;
        okButton.Text = "ОК";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += OkButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(549, 210);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(105, 38);
        cancelButton.TabIndex = 6;
        cancelButton.Text = "Отмена";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // descriptionLabel
        // 
        descriptionLabel.Location = new Point(20, 9);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(634, 40);
        descriptionLabel.TabIndex = 0;
        descriptionLabel.Text = "Парольная фраза";
        // 
        // PhraseForm
        // 
        AcceptButton = okButton;
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(666, 260);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(confirmTextBox);
        Controls.Add(confirmLabel);
        Controls.Add(phraseTextBox);
        Controls.Add(phraseLabel);
        Controls.Add(descriptionLabel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PhraseForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Парольная фраза";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label descriptionLabel;
}
