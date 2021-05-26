using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductTranslation
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDesciption { get; set; }
        public string SeoTitle{ get; set; }
        public Guid LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
