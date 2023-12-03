using BlogWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Entity.Entities
{
    public class Image : EntityBase, IEntityBase
    {
     

        public string Fileame { get; set; }

        public string  FileType { get; set; }


        public ICollection<Image> Images { get; set;}


    }
}
