using AccessControl.Core;

namespace AccessControl.Desktop;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        string folder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "AccessControlLab1");
        string file = Path.Combine(folder, "users.dat");

        using var phraseForm = new PhraseForm(!File.Exists(file));
        if (phraseForm.ShowDialog() != DialogResult.OK)
        {
            MessageBox.Show("Ввод парольной фразы отменён. Работа программы завершена.",
                "Завершение работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            var store = new EncryptedUserStore(file, phraseForm.Phrase);
            var service = new UserService(store.Load(), store.Save);

            using var loginForm = new LoginForm(service);
            if (loginForm.ShowDialog() != DialogResult.OK)
                return;

            UserAccount user = service.CurrentUser!;
            if (!user.IsPasswordSet || user.IsPasswordExpired(DateTime.Now))
            {
                using var passwordForm = new PasswordForm(service, required: true);
                if (passwordForm.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new MainForm(service));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
