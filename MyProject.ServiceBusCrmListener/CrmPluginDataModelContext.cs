using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.ServiceBusCrmListener
{
    class CrmPluginDataModelContext : DbContext
    {
        public DbSet<CrmPluginDataModel> CrmPluginDataModels { get; set; }
    }
}
