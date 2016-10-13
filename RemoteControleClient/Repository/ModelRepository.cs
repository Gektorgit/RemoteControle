using RemoteControleClient.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControleClient.Repository
{
    public class UsersRepository : SimpleRepository<Users>
    {
        protected override DbSet<Users> dbSet
        {
            get { return context.Users; }
        }
    }
    public class ConfigurationRepository : SimpleRepository<Configuration>
    {
        protected override DbSet<Configuration> dbSet
        {
            get { return context.Configuration; }
        }
    }
    public class BannedProgrammsRepository : SimpleRepository<BannedProgramms>
    {
        protected override DbSet<BannedProgramms> dbSet
        {
            get { return context.BannedProgramms; }
        }
    }
    public class DaysOfWeekRepository : SimpleRepository<DaysOfWeek>
    {
        protected override DbSet<DaysOfWeek> dbSet
        {
            get { return context.DaysOfWeek; }
        }
    }

}
