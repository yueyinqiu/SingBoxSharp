namespace SingBoxSharp.Configuration.Log;

public sealed class SingBoxLog
{
    public bool? Disabled { get; set; }
    public SingBoxLogLevel? Level { get; set; }
    public string? Output { get; set; }
    public bool? Timestamp { get; set; }
}
