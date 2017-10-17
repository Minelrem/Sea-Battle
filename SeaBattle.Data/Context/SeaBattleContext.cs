using SeaBattle.Data.Model;
using System.Data.Entity;

namespace SeaBattle.Data.Context
{
    public class SeaBattleContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public SeaBattleContext(): base("SeaBattleConnection")
        {
            
        }

        public SeaBattleContext(string connectionStringOrName): base(connectionStringOrName)
        {
            
        }
    }
}
