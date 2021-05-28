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

                    Battery battery = FetchBatteryParamters();

                    StringBuilder sb = new StringBuilder();
                    sb.Append($"Charge State: {battery.ChargeState} ");
                    sb.Append($"Temprature: {battery.Temperature}");
                    Console.WriteLine(sb);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        public static Battery FetchBatteryParamters()
        {
            System.Random randomNumber = new System.Random();
            Battery batteryParameter = new Battery();
            batteryParameter.ChargeState = randomNumber.Next(BMSConstants.MinChargeState, BMSConstants.MaxChargeState);
            batteryParameter.Temperature = randomNumber.Next(BMSConstants.MinTemperature, BMSConstants.MaxTemperature);
            return batteryParameter;
        }
    }
}
