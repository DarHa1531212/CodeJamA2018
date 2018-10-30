using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJamA2018
{
    class ControllerAccess
    {

        public tblUser getUsers(string username)
        {
            DataModel model1 = new DataModel();
  

            var query = from user in model1.tblUser
                        select user;

            foreach (var genreSelectionne in query)
            {
                if (username == genreSelectionne.noEmploye)
                {
                    return genreSelectionne;
                }
            }

            return null;
            
        }
    }
}
