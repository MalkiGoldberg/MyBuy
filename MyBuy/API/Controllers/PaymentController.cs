using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PaymentController:ApiController
    {
        public DTO.PaymentDTO Get(int id)
        {
            BL.PaymentBL paymentBL = new BL.PaymentBL();
            return paymentBL.GetPayment(id);
        }
        [HttpGet]
        [Route("api/Payment/GetPayments")]
        public List<DTO.PaymentDTO> Get()
        {
            BL.PaymentBL paymentBL = new BL.PaymentBL();
            return paymentBL.GetPayments();
        }
    }
}