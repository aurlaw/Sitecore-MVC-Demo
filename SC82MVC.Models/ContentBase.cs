using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC82MVC.Models
{
    public class ContentBase
    {
        public virtual Guid Id { get; set; }
        public virtual string Url { get; set; }

    }
}