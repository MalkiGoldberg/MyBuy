using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentDal
    {
        public Payment GetPayment(int id)
        {
            try
            {
                using (MyBuyEntities db=new MyBuyEntities())
                {
                    return db.Payments.Single(i => i.paymentId == id);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Payment> GetPayments()
        {
            try
            {
                using (MyBuyEntities db=new MyBuyEntities())
                {
                   return db.Payments.ToList();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
