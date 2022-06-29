using MessageSender;
class Program
{
    public static void Main(string[] args)
    {
        MessageTemp.PhoneNumber = "+420725925390";
        MessageTemp.MessageBody = "Funguje to takhle"; 
        SmsMessaging.SendMessage();
    }
}