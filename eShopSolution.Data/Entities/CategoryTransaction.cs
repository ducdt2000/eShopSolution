using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class CategoryTransaction
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public Guid LanguageId { get; set; }
        public string SeoAlias { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
    }
}
