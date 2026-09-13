namespace AccessControl.Core;

public enum LoginResult
{
    Success,
    UserNotFound,
    UserBlocked,
    WrongPassword,
    AttemptsExceeded
}

public sealed class UserService
{
    private readonly List<UserAccount> users;
    private readonly Action<IReadOnlyList<UserAccount>> save;
    private int failedAttempts;

    public UserService(IEnumerable<UserAccount> users, Action<IReadOnlyList<UserAccount>> save)
    {
        this.users = users.ToList();
        this.save = save;
    }

    public UserAccount? CurrentUser { get; private set; }

    public IReadOnlyList<UserAccount> Users => users;

    public LoginResult Login(string name, string password)
    {
        if (failedAttempts >= 3)
            return LoginResult.AttemptsExceeded;

        UserAccount? user = users.FirstOrDefault(u =>
            string.Equals(u.Name, name.Trim(), StringComparison.OrdinalIgnoreCase));

        if (user is null)
            return LoginResult.UserNotFound;
        if (user.IsBlocked)
            return LoginResult.UserBlocked;
        if (user.PasswordHash != PasswordHelper.Hash(password, user.PasswordSalt))
        {
            failedAttempts++;
            return failedAttempts >= 3
                ? LoginResult.AttemptsExceeded
                : LoginResult.WrongPassword;
        }

        CurrentUser = user;
        return LoginResult.Success;
    }

    public void AddUser(string name)
    {
        RequireAdmin();
        name = name.Trim();

        if (name.Length == 0)
            throw new InvalidOperationException("Введите имя пользователя.");
        if (users.Any(u => string.Equals(u.Name, name, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Такой пользователь уже существует.");

        string salt = PasswordHelper.CreateSalt();
        users.Add(new UserAccount
        {
            Name = name,
            PasswordSalt = salt,
            PasswordHash = PasswordHelper.Hash("", salt)
        });
        save(users);
    }

    public void UpdateUser(UserAccount user, bool blocked, bool restriction, int minimumLength, int validityMonths)
    {
        RequireAdmin();

        if (user.IsAdmin && blocked)
            throw new InvalidOperationException("Учётную запись ADMIN нельзя заблокировать.");
        if (minimumLength < 0 || validityMonths < 0)
            throw new InvalidOperationException("Параметры пароля не могут быть отрицательными.");

        user.IsBlocked = blocked;
        user.UsePasswordRestriction = restriction;
        user.MinimumPasswordLength = minimumLength;
        user.PasswordValidityMonths = validityMonths;
        save(users);
    }

    public void ChangePassword(string oldPassword, string newPassword, string confirmation)
    {
        UserAccount user = CurrentUser ?? throw new InvalidOperationException("Пользователь не вошёл в программу.");

        if (user.PasswordHash != PasswordHelper.Hash(oldPassword, user.PasswordSalt))
            throw new InvalidOperationException("Неверный старый пароль.");
        if (newPassword != confirmation)
            throw new InvalidOperationException("Пароль и подтверждение не совпадают.");
        if (!PasswordHelper.IsValid(user, newPassword, out string error))
            throw new InvalidOperationException(error);

        user.PasswordHash = PasswordHelper.Hash(newPassword, user.PasswordSalt);
        user.IsPasswordSet = true;
        user.PasswordChangedAt = DateTime.Now;
        save(users);
    }

    private void RequireAdmin()
    {
        if (CurrentUser?.IsAdmin != true)
            throw new InvalidOperationException("Операция доступна только администратору.");
    }
}
