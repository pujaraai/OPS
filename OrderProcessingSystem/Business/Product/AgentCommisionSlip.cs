using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Product
{
    public class AgentCommisionSlip
    {
        public bool AgentCommission(int CommissionSlipID, Double Amount)
        {
            // There is a Business Rule that Agent Commission Can not be more that 10 $
            bool isPermitCommission = false;
            if (Amount < 10)
                isPermitCommission = true;
            else
                isPermitCommission = false;

            return isPermitCommission;
        }
    }
    
}
