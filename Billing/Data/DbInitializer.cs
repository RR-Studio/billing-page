using System.Linq;
using SQLitePCL;

namespace Billing.Data
{
    public class DbInitializer
    {

        public static void Initialize(MyContext context)
        {
            context.Database.EnsureCreated();

           
        }
    }
}