using RxTelegram.Bot.Interface.BaseTypes.Requests.Base;

namespace RxTelegram.Bot.Interface.BaseTypes.Requests.Chats
{
    /// <summary>
    /// Use this method to get up to date information about the chat (current name of the user for one-on-one conversations, current
    /// username of a user, group or channel, etc.). Returns a Chat object on success.
    /// </summary>
    public class GetChat : BaseRequest
    {
        protected override void Validate() => throw new System.NotImplementedException();
    }
}
