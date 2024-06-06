using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsUserFactory
    {
        public static MsUser Create(int UserId, String Username, String UserEmail, DateTime UserDOB, String UserGender, String UserRole)
        {
            MsUser newUser = new MsUser();
            
            newUser.UserID = UserId;
            newUser.UserName = Username;
            newUser.UserEmail = UserEmail;
            newUser.UserDOB = UserDOB;
            newUser.UserGender = UserGender;
            newUser.UserRole = UserRole;

            return newUser;
        }
    }
}