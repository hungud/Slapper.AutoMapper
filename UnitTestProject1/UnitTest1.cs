using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string customer_data = @"{
    'SQ_ID': 61,
    'CTM_CODE': '1023',
    'EMAIL': 'hungudgm@gmail.com',
    'MOBILE': '0989700689',
    'REF_SPC_006_GP_ID': 0,
    'COUNT_INIT_FLIGHT': 0,
    'COUNT_FLIGHT_STATUS_3': 44,
    'COUNT_FLIGHT_INTL_STATUS_3': 9
}";





            dynamic customer = Newtonsoft.Json.JsonConvert.DeserializeObject(customer_data);

            var customer_data_object = Slapper.AutoMapper.MapDynamic<CustomerData>(customer);



        }
    }
}
