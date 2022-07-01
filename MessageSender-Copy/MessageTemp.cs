
namespace MessageSender
{
    /// <summary>
    /// Mezi vrstva pro všechny brány
    /// </summary>
    abstract public class MessageTemp
    {
        internal static string accountSid = "AC93ccc409edf104a7cdf128894a7d6ab2";
        internal static string authToken = "e9e79c24d336051573abc1cc7f5a9086";

        /// <summary>
        /// Telefonní číslo na které se zpráva pošle
        /// </summary>
        public static string? PhoneNumber { get; set; }
        /// <summary>
        /// Samotná zpráva
        /// </summary>
        public static string? MessageBody { get; set; }

        
        public MessageTemp(string phoneNumber, string messageBody)
        {
            PhoneNumber = phoneNumber;
            MessageBody = messageBody;
        }

    }
}
