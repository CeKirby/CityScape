﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class Transfer
    {
        public int? TransferId { get; set; }
        public int TransferTypeId { get; set; }
        public int TransferStatusId { get; set; }
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public decimal Amount { get; set; }

        public Transfer()
        {

        }
        public Transfer( int transferTypeId, int transferStatusId, int accountFrom, int accountTo, decimal amount)
        {
       
            TransferTypeId = transferTypeId;
            TransferStatusId = transferStatusId;
            AccountFrom = accountFrom;
            AccountTo = accountTo;
            Amount = amount;
        }

    }
    public class TransferStatus
    {
        //Pending(1) Approved(2) Rejected(3)
        public int TransferStatusId { get; set; }

        public string TransferStatusDesc { get; set; }
    }
    public class TransferType
    {
        // request(1) or send(2)
        public int TransferTypeId { get; set; }

        public string TransferTypeDesc { get; set; }
    }
}
