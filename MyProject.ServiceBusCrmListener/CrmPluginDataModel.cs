using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.ServiceBusCrmListener
{
    public class CrmPluginDataModel
    {
        public int ContextId { get; set; }
        public string EntityName { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
