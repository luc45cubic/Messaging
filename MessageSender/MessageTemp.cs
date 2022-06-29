using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MessageSender
{
    abstract public class MessageTemp
    {
        internal static string accountSid = "AC93ccc409edf104a7cdf128894a7d6ab2";
        internal static string authToken = "e9e79c24d336051573abc1cc7f5a9086";

        public static string PhoneNumber { get; set; }
        public static string MessageBody { get; set; }

        public MessageTemp(string phoneNumber, string messageBody)
        {
            PhoneNumber = phoneNumber;
            MessageBody = messageBody;
        }

    }
}
