using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsSupplementFactory
    {
        public static MsSupplement Create(int id, String name, DateTime expiryDate, int price, int typeId)
        {
            MsSupplement newSupplement = new MsSupplement();

            newSupplement.SupplementID = id;
            newSupplement.SupplementName = name;
            newSupplement.SupplementExpiryDate = expiryDate;
            newSupplement.SupplementPrice = price;
            newSupplement.SupplementTypeID = typeId;

            return newSupplement;
        }
    }
}