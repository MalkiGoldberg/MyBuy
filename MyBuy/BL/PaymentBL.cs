using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PaymentBL
    {
        public DTO.PaymentDTO GetPayment(int id)
        {
            return Converts.PaymentConverts.GetPaymentDTOFromDal(new DAL.PaymentDal().GetPayment(id));
        }

        public List<DTO.PaymentDTO> GetPayments()
        {
            return Converts.PaymentConverts.GetPaymentsDTOFromDal(new DAL.PaymentDal().GetPayments());
        }
    }
}
