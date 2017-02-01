using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Specialized;

namespace DomainModel
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
