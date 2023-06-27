﻿using RxTelegram.Bot.Interface.BaseTypes;

namespace RxTelegram.Bot.Interface.InlineMode;

/// <summary>
/// Note: It is necessary to enable inline feedback via @Botfather in order to receive these objects in updates.
/// </summary>
public class ChosenInlineResult
{
    /// <summary>
    /// The unique identifier for the result that was chosen
    /// </summary>
    public string ResultId { get; set; }

    /// <summary>
    /// The user that chose the result
    /// </summary>
    public User From { get; set; }

    /// <summary>
    /// Optional. Sender location, only for bots that require user location
    /// </summary>
    public Location Location { get; set; }

    /// <summary>
    /// Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message.
    /// Will be also received in callback queries and can be used to edit the message.
    /// </summary>
    public string InlineMessageId { get; set; }

    /// <summary>
    /// The query that was used to obtain the result
    /// </summary>
    public string Query { get; set; }
}