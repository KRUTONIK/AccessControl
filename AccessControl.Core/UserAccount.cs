namespace AccessControl.Core;

public sealed class UserAccount
{
    public string Name { get; set; } = "";
    public string PasswordHash { get; set; } = PasswordHelper.Hash("");
    public string PasswordSalt { get; set; } = "";
    public bool IsPasswordSet { get; set; }
    public bool IsBlocked { get; set; }
    public bool UsePasswordRestriction { get; set; }
    public int MinimumPasswordLength { get; set; }
    public int PasswordValidityMonths { get; set; }
    public DateTime? PasswordChangedAt { get; set; }

    public bool IsAdmin => Name == "ADMIN";

    public bool IsPasswordExpired(DateTime now) =>
        IsPasswordSet && PasswordValidityMonths > 0 &&
        PasswordChangedAt!.Value.AddMonths(PasswordValidityMonths) <= now;
}
