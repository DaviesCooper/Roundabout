public static class Program
{
    #region CONSTS

    private const string CANVAS_DIAMETER_ARG = "-D";
    private const string THREAD_THICKNESS_ARG = "-TTh";
    private const string GRID_RESOLUTION_ARG = "-R";
    private const string PIN_THICKNESS_ARG = "-PTh";

    #endregion

    public static void Main(string[] args)
    {
        // Pulling args from command line.
        string? canvasDiameter = GetArg(args, CANVAS_DIAMETER_ARG);
        string? threadThickness = GetArg(args, THREAD_THICKNESS_ARG);
        string? gridResolution = GetArg(args, GRID_RESOLUTION_ARG);
        string? pinThickness = GetArg(args, PIN_THICKNESS_ARG);
    }

    #region HELPERS

    /// <summary>
    /// Returns true if an array of string contains the specified string.
    /// Used for determining whether the command line arguments contain a flag.
    /// </summary>
    /// <param name="args">The array of string to search.</param>
    /// <param name="flag">The flag to search for.</param>
    public static bool GetFlag(string[] args, string flag)
    {
        for(int i = 0; i < args.Length; i++)
        {
            if (args[0].Equals(flag))
                return true;
        }
        return false;
    }

    /// <summary>
    /// Returns the value of a specified argument from an array of strings.
    /// Used for determining whether the command line arguments contain an argument.
    /// 
    /// If the specified argument is not provided, this returns null.
    /// </summary>
    /// <param name="args">The array of string to search.</param>
    /// <param name="arg">The argument to search for.</param>
    public static string? GetArg(string[] args, string arg)
    {
        for (int i = 0; i < args.Length - 1; i++)
        {
            if (args[0].Equals(arg))
                return args[i+1];
        }
        return null;
    }

    #endregion
}