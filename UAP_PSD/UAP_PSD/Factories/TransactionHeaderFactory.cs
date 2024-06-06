using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int TransactionID, int UserID, DateTime TransactionDate, String Status)
        {
            TransactionHeader newTransactionHeader = new TransactionHeader();
            newTransactionHeader.TransactionID = TransactionID;
            newTransactionHeader.UserID = UserID;
            newTransactionHeader.TransactionDate = TransactionDate;
            newTransactionHeader.Status = Status;
            return newTransactionHeader;
        }
    }
}