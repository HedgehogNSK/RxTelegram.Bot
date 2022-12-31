namespace RxTelegram.Bot.Interface.BaseTypes;

/// <summary>
/// This object represents a service message about an edited forum topic.
/// </summary>
public class ForumTopicEdited
{
    /// <summary>
    /// Optional. New name of the topic, if it was edited
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional. New identifier of the custom emoji shown as the topic icon, if it was edited; an empty string if the icon was removed
    /// </summary>
    public string IconCustomEmojiId { get; set; }
}
