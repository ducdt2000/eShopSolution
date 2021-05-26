using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class SystemActivity
    {
        public Guid Id { get; set; }
        public string ActivityName { get; set; }
        public DateTime ActivityDate { get; set; }
        public Guid FunctionId { get; set; }
        public string UserIP { get; set; }
        public string ClientIP { get; set; }

    }
}
