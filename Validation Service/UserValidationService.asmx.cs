using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Validation_Service
{
    /// <summary>
    /// Summary description for UserValidationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserValidationService : System.Web.Services.WebService
    {

        [WebMethod]
        public bool LoginUser(string name, string password)
        {
            UserDbEntities dbEntities = new UserDbEntities();
            var user = dbEntities.Users.FirstOrDefault(x => x.user_name == name && x.password == password);

            if(user == null)
                return false;
            else
                return true;
        }

        [WebMethod]
        public int RegisterUser(string name,string pass,string email,int age)
        {
            User user = new User();
            user.user_mail = email;
            user.user_name = name;
            user.age = age;
            user.password = pass;

            UserDbEntities dbEntities = new UserDbEntities();
            var newuser = dbEntities.Users.Add(user);
            dbEntities.SaveChanges();

            return newuser.user_id;
        }
    }
}
