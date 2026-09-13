namespace AccessControl.Desktop;

public partial class PhraseForm : Form
{
    private readonly bool isFirstRun;

    public PhraseForm() : this(false) { }

    public PhraseForm(bool isFirstRun)
    {
        InitializeComponent();
        this.isFirstRun = isFirstRun;
        confirmLabel.Visible = confirmTextBox.Visible = isFirstRun;
        descriptionLabel.Text = isFirstRun
            ? "Первый запуск. Задайте парольную фразу для шифрования файла пользователей."
            : "Введите парольную фразу для открытия файла пользователей.";
    }

    public string Phrase { get; private set; } = "";

    private void OkButton_Click(object? sender, EventArgs e)
    {
        if (phraseTextBox.Text.Length == 0)
        {
            MessageBox.Show("Введите парольную фразу.");
            return;
        }
        if (isFirstRun && phraseTextBox.Text != confirmTextBox.Text)
        {
            MessageBox.Show("Парольные фразы не совпадают.");
            return;
        }

        Phrase = phraseTextBox.Text;
        DialogResult = DialogResult.OK;
    }
}
