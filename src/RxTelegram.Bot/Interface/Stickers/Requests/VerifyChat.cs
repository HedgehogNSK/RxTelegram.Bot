using RxTelegram.Bot.Interface.BaseTypes;
using RxTelegram.Bot.Interface.Validation;
using RxTelegram.Bot.Validation;

namespace RxTelegram.Bot.Interface.Stickers.Requests;

/// <summary>
/// Verifies a chat on behalf of the organization which is represented by the bot. Returns True on success.
/// </summary>
public class VerifyChat : BaseValidation
{
    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
    /// </summary>
    public ChatId ChatId { get; set; }

    /// <summary>
    /// Custom description for the verification; 0-70 characters.
    /// Must be empty if the organization isn't allowed to provide a custom verification description.
    /// </summary>
    public string CustomDescription { get; set; }

    protected override IValidationResult Validate() => this.CreateValidation();
}
