using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using System.Diagnostics;

namespace AccountLockOutCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);

            // find a user
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, "Sarvesh Yerawar");

            if (user != null)
            {
                string displayName = user.DisplayName;

                Console.WriteLine(displayName);
                Console.WriteLine("Is Account Locked Out?: " + user.IsAccountLockedOut());

                Console.ReadLine();
            }
        }
    }
}
