using FullSerializer;
using System.Collections.Generic;

/// <summary>
/// The mesage response.
/// </summary>
#region MessageResponseExt
[fsObject]
public class MessageResponseExt
{
    /// <summary>
    /// The input text.
    /// </summary>
    public Dictionary<string, object> input { get; set; }
    /// <summary>
    /// State information for the conversation .
    /// </summary>
    public Dictionary<string, object> context { get; set; }
    /// <summary>
    /// Terms from the request that are identified as entities.
    /// </summary>
    public RuntimeEntity[] entities { get; set; }
    /// <summary>
    /// Terms from the request that are identified as intents.
    /// </summary>
    public RuntimeIntent[] intents { get; set; }
    /// <summary>
    /// Output from the dialog, including the response to the user, the nodes that were triggered, and log messages.
    /// </summary>
    public OutputData output { get; set; }
    /// <summary>
    /// Whether to return more than one intent. true indicates that all matching intents are returned. 
    /// </summary>
    public bool alternate_intents { get; set; }
}

/// <summary>
/// The entity object.
/// </summary>
[fsObject]
public class RuntimeEntity
{
    /// <summary>
    /// The entity name.
    /// </summary>
    public string entity { get; set; }
    /// <summary>
    /// The entity location.
    /// </summary>
    public int[] location { get; set; }
    /// <summary>
    /// The entity value.
    /// </summary>
    public string value { get; set; }
}

/// <summary>
/// The resultant intent.
/// </summary>
[fsObject]
public class RuntimeIntent
{
    /// <summary>
    /// The intent.
    /// </summary>
    public string intent { get; set; }
    /// <summary>
    /// The confidence.
    /// </summary>
    public float confidence { get; set; }
}

/// <summary>
/// The Output data.
/// </summary>
[fsObject]
public class OutputData
{
    /// <summary>
    /// Log messages.
    /// </summary>
    public RuntimeLogMessage[] log_messages { get; set; }
    /// <summary>
    /// Output text.
    /// </summary>
    public string[] text { get; set; }
    /// <summary>
    /// Action.
    /// </summary>
    public string action { get; set; }
    /// <summary>
    /// Location.
    /// </summary>
    public string location { get; set; }
    /// <summary>
    /// The nodes that were visited.
    /// </summary>
    public string[] nodes_visited { get; set; }
}

/// <summary>
/// The log message object.
/// </summary>
[fsObject]
public class RuntimeLogMessage
{
    /// <summary>
    /// The log level.
    /// </summary>
    public string level { get; set; }
    /// <summary>
    /// The log message.
    /// </summary>
    public string msg { get; set; }
}
#endregion
