﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Payment
{
    public class CashService : IPaymentService
    {

        public string Pay(double amount)
        {
            return $"Amount: {amount} is paid through Cash";
        }
    }
}