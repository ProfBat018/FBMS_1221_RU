using System;

namespace SessionInfo;

public class MessageInfo
{
    public string Username { get; init; }
    public DateTime Date { get; init; }
    public string Message { get; init; }

    public override string ToString()
    {
        return $"[{Date}]: {Message}";
    }
}