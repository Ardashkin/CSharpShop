using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceContract;
using DomainModel;
using Repository;




namespace WcfService
{
    
    public class Service : IService
    {
        public string GetData()
        {
            return "Hello";
        }

        public void SetData()
        {
            ProductPrice prod1 = new ProductPrice
            {
                Price = 6000,
                EffectiveDate = new DateTime(2018, 12, 31)
            };

            Repository<ProductPrice> repo = new Repository<ProductPrice>();
            repo.Create(prod1);
            repo.Save();


            //    Repository<ProductPrice> repo = new Repository<ProductPrice>();
            //    repo.Create(prod1);
            //    repo.Save();

        }
    }
}