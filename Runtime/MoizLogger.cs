using UnityEngine;

public static class MoizLogger
{
    private static LogLevel currentLogLevel = LogLevel.Info; // Default log level

    // Initialize the logger with user-defined settings
    public static void Initialize(LogConfig config)
    {
        currentLogLevel = config.LogLevel;
        // Additional configuration setup can be handled here
    }
        
    public static void Info(string message)
    {
        Debug.Log($"[INFO] {message}");
    }

    public static void Warning(string message)
    {
        // Debug.LogWarning($"[WARNING] {message}");
    }

    public static void Error(string message)
    {
        // Debug.LogError($"[ERROR] {message}");
    }

    public static void Debug(string message)
    {
        // Use standard Debug.Log for debug messages, but with a prefix
        // Debug.Log($"[DEBUG] {message}");
    }

    public static void Critical(string message)
    {
        // Since Unity doesn't have a specific critical log method, use error log with critical notice
        // Debug.LogError($"[CRITICAL] {message}");
    }
}



public class MoizLogConfig
{
    public LogLevel LogLevel { get; set; }

    public MoizLogConfig()
    {
        // Default to info level
        LogLevel = LogLevel.Info;
    }
}