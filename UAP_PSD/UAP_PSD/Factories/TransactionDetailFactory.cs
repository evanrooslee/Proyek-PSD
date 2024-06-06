using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int TransactionID, int SupplementID, int Quantity)
        {
            TransactionDetail newTransactionDetail = new TransactionDetail();
            newTransactionDetail.TransactionID = TransactionID;
            newTransactionDetail.SupplementID = SupplementID;
            newTransactionDetail.Quantity = Quantity;
            return newTransactionDetail;
        }
    }
}