using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MessageSender
{

    public class SmsMessaging : MessageTemp
    {
        public SmsMessaging(string phoneNumber, string messageBody) : base(phoneNumber, messageBody)
        {
            PhoneNumber = phoneNumber;
            MessageBody = messageBody;
        }

        public static void SendMessage()
        {
            TwilioClient.Init(accountSid, authToken);
            var messageOptions = new CreateMessageOptions(
                new PhoneNumber(PhoneNumber));
            messageOptions.MessagingServiceSid = "MG6b6cf34ea96b95f65627721f4baa0b6b";
            messageOptions.Body = MessageBody;

            MessageResource.Create(messageOptions);
        }
        
    }
}
