using System;
using System.Text;

namespace BMSSender
{
    public class BatteryInformationSender : ISender
    {
        
        public void SendDataToConsole()
        {
            try
            {               
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(5000);
                   
                     FetchBatteryData();

                    StringBuilder sb = new StringBuilder();
                    sb.Append($"Charge State: {Battery.ChargeState} ");
                    sb.Append($"Temprature: {Battery.Temperature}");
                    Console.WriteLine(sb);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        private static void FetchBatteryData()
        {
            System.Random randomNumber = new System.Random();
            Battery.ChargeState = randomNumber.Next(2, 10);
            Battery.Temperature = randomNumber.Next(10, 50);         
        }
    }
}
