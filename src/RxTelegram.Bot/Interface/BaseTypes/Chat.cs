﻿using System;
using System.Collections.Generic;
using System.Threading;
using RxTelegram.Bot.Interface.BaseTypes.Enums;
using RxTelegram.Bot.Interface.BaseTypes.Requests.Chats;
using RxTelegram.Bot.Interface.Business;
using RxTelegram.Bot.Interface.Reaction;

namespace RxTelegram.Bot.Interface.BaseTypes;

/// <summary>
/// This object represents a chat.
/// </summary>
public class Chat
{
    /// <summary>
    /// Unique identifier for this chat.
    /// This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it.
    /// But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Type of chat
    /// </summary>
    public ChatType Type { get; set; }

    /// <summary>
    /// Optional. Title, for supergroups, channels and group chats
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Optional. Username, for private chats, supergroups and channels if available
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Optional. First name of the other party in a private chat
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Optional. Last name of the other party in a private chat
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Optional. True, if the supergroup chat is a forum (has topics enabled)
    /// </summary>
    public bool IsForum { get; set; }
}
