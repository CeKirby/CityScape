﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TenmoClient.Data
{
    public class Transfer
    {
        public int TransferId { get; set; }
        public int TransferTypeId { get; set; }
        public int TransferStatusId { get; set; }
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public decimal Amount { get; set; }

        public Transfer()
        {

        }
        public Transfer(int transferTypeId, int transferStatusId, int accountFrom, int accountTo, decimal amount)
        {
           
            TransferTypeId = transferTypeId;
            TransferStatusId = transferStatusId;
            AccountFrom = accountFrom;
            AccountTo = accountTo;
            Amount = amount;
        }
    }

}
