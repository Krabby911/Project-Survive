static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(":");
        return logLine.Substring(colonIndex + 2).Trim();
    }

    public static string LogLevel(string logLine)
    {
        
        int closeBracketIndex = logLine.IndexOf("]");
        String level = logLine.Substring(1 , closeBracketIndex - 1).Trim();
        
        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        int colonIndex = logLine.IndexOf(":");
        string line = logLine.Substring(colonIndex + 2).Trim();

        int closeBracketIndex = logLine.IndexOf("]");
        String level = logLine.Substring(1 , closeBracketIndex - 1).Trim().ToLower();

        return $"{line} ({level})";
    }
}
