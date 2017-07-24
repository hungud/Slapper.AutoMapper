using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [Serializable]
    public class CustomerData
    {
        public decimal SQ_ID { get; set; }
        public string CTM_CODE { get; set; }

        public string EMAIL { get; set; }

        public string MOBILE { get; set; }

        public decimal REF_SPC_006_GP_ID { get; set; }

        public decimal COUNT_INIT_FLIGHT { get; set; }
        public decimal COUNT_FLIGHT_STATUS_3 { get; set; }
        public decimal COUNT_FLIGHT_INTL_STATUS_3 { get; set; }
    }
}
