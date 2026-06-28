public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int indexofDelimeter = str.IndexOf(delimiter);
        string result = str.Substring(indexofDelimeter + delimiter.Length);
        return result;
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        string afterStart = str.SubstringAfter(startDelimiter);
        int endPos = afterStart.IndexOf(endDelimiter);
        return afterStart.Substring(0, endPos);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        string message = str.SubstringAfter(": ");
        return message;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        string level =  str.SubstringBetween("[","]");
        return level;
    }
}