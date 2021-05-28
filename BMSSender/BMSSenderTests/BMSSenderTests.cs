using BMSSender;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMSSenderTests
{
    [TestClass]
    public class BMSSenderTests
    {
        [TestMethod]
        public void WhenFetchBatteryParamtersCalled_ThenReturnValidBatteryChargeStateReading()
        {           
            Battery result = BatteryInformationSender.FetchBatteryParamters();
            Assert.IsTrue(result.ChargeState > BMSConstants.MinChargeState && result.ChargeState < BMSConstants.MaxChargeState);
        }

        [TestMethod]
        public void WhenFetchBatteryParamtersCalled_ThenReturnValidBatteryTemperatureReading()
        {
            Battery result = BatteryInformationSender.FetchBatteryParamters();
            Assert.IsTrue(result.Temperature > BMSConstants.MinTemperature && result.Temperature < BMSConstants.MaxTemperature);
        }
    }
}
