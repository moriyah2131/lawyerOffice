﻿using BLL.interfaces;
using Dal.interfaces;
using EntitiesDTO;
using System.Collections.Generic;

namespace BLL.classes
{
    public class PaymentsBll : IpaymentsBll
    {
        public Ipayments dal;
        public PaymentsBll(Ipayments _dal)
        {
            dal = _dal;
        }

        public List<PaymentsDto> GetAll()
        {
            return dal.GetAll();
        }

        public PaymentsDto GetById(int id)
        {
            return dal.GetById(id);
        }

        public PaymentsDto post(PaymentsDto obj)
        {
            return dal.post(obj);
        }

        public PaymentsDto put(PaymentsDto obj)
        {
            return dal.put(obj);
        }

        public PaymentsDto delete(int id)
        {
            return dal.delete(id);
        }
    }
}
