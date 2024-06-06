using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsSupplementTypeFactory
    {
        public static MsSupplementType Create(int SupplementTypeID, int SupplementTypeName)
        {
            MsSupplementType newSupplementType = new MsSupplementType();

            newSupplementType.SupplementTypeID = SupplementTypeID;
            newSupplementType.SupplementTypeName = SupplementTypeName;
            return newSupplementType;
        }
    }
}