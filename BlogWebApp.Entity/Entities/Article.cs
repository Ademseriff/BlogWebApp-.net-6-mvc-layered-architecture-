using BlogWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Entity.Entities
{
    public class Article : EntityBase ,IEntityBase
    {



        public string Title { get; set; }

        public string Content { get; set; }


        public int ViewCount { get; set; }


        public Guid CatagoryId { get; set; }
        public Category Catagory { get; set; }

        public Guid ImageId { get; set; }

        public Image Image { get; set; }





    }
}
