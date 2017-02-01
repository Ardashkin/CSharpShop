using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    public class ProductPrice : BaseModel
    {
        public double Price { get; set; }
        public DateTime EffectiveDate { get; set; }
        public override string ToString()
        {
            return String.Format("Id->{0}\nPrice->{1}\nEffectiveDate->{2}\n",
                this.Id,
                this.Price,
                this.EffectiveDate.ToShortDateString()
                );
        }
    }
}
