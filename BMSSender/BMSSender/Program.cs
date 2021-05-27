namespace BMSSender
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender sender = new BatteryInformationSender();
            sender.SendDataToConsole();
        }
    }
}
