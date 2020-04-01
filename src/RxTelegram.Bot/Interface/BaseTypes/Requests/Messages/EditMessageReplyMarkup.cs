﻿using RxTelegram.Bot.Interface.BaseTypes.Requests.Base;
using RxTelegram.Bot.Validation;

namespace RxTelegram.Bot.Interface.BaseTypes.Requests.Messages
{
    /// <summary>
    /// Use this method to edit only the reply markup of messages. On success, if edited message is sent by the bot, the edited Message is
    /// returned, otherwise True is returned.
    /// </summary>
    public class EditMessageReplyMarkup : BaseRequest
    {
        /// <summary>
        /// Required if inline_message_id is not specified. Identifier of the message to edit
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Required if chat_id and message_id are not specified. Identifier of the inline message
        /// </summary>
        public string InlineMessageId { get; set; }

        /// <summary>
        /// A JSON-serialized object for an inline keyboard.
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        protected override IValidationResult Validate() => throw new System.NotImplementedException();
    }
}
