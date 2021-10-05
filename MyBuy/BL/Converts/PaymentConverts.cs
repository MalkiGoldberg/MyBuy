using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class PaymentConverts
    {
        public static DTO.PaymentDTO GetPaymentDTOFromDal(DAL.Payment payment)
        {
            DTO.PaymentDTO paymentDTO = new DTO.PaymentDTO();
            paymentDTO.paymentId = payment.paymentId;
            paymentDTO.paymentDescription = payment.paymentDescription;
            return paymentDTO;
        }

        public static List<DTO.PaymentDTO> GetPaymentsDTOFromDal(List<DAL.Payment> payments)
        {
            List<DTO.PaymentDTO> paymentDTOs = new List<DTO.PaymentDTO>();
            foreach (var item in payments)
            {
                paymentDTOs.Add(GetPaymentDTOFromDal(item));
            }
            return paymentDTOs;
        }
    }
}
