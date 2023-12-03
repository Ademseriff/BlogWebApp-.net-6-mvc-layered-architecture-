﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebApp.Core.Entities
{
    public abstract class EntityBase :IEntityBase
    {


        public virtual Guid Id { get; set; } = new Guid(); 
        public virtual  string? CreateBy { get; set; }
               
        public virtual int? DeleteBy { get; set; }
               
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
               
        public virtual DateTime? ModifiedDate { get; set; }
               
        public virtual DateTime? DeletedDate { get; set; }
               
        public virtual bool IsDeleted { get; set; }= false;
    }
}
