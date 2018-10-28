using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJamA2018
{
   class loginInfo
    {

        public static tblUser logedInUser;

            public tblUser LogedInUser
        {
            get { return logedInUser; }
            set { logedInUser = value; }
        }

        public void setLogin(tblUser user)
        {
            LogedInUser = user;
        }
    }
}
