namespace MoneyExtensions;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount <= 0) return 0;

        var text = amount.ToString("N2").Replace(",", "").Replace(".", ""); //TODO: trocar por um regex

        if (string.IsNullOrEmpty(text)) return 0;

        int.TryParse(text, out var result);
        return result;
    }
}

