using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository;
using DomainModel;

namespace ServiceContract
{
    public class ShopServiceBase<TEntity> : IShopServiceBase<TEntity> where TEntity : BaseModel
    {
        protected readonly IRepository<TEntity> repository;

        public void Create(TEntity item)
        {
            var prod = new ProductPrice
            {
                Price = 6000,
                EffectiveDate = new DateTime(2018, 12, 31)
            };
            Repository<ProductPrice> repo = new Repository<ProductPrice>();
            repo.Create(prod);
            repo.Save();

            //repository.Create(item);
            //OnCreateEvent(item);
            //repository.Save();
            //OnSaveEvent(item);
        }

        public IEnumerable<TEntity> GetItems()
        {
            return repository.GetItems();
        }

        public void Update(TEntity item)
        {
            repository.Update(item);
            //OnUpdateEvent(item);
            repository.Save();
            // OnSaveEvent(item);
        }

        public void Delete(TEntity item)
        {
            repository.Delete(item);
            //OnDeleteEvent(item);
            repository.Save();
            //OnSaveEvent(item);
        }

        /*
        protected virtual void OnCreateEvent(TEntity item)
        {
            EntryCreateEventHandler<TEntity> handler = CreateEvent;
            handler?.Invoke(this, new EntryEventArgs<TEntity>(item));
        }
        protected virtual void OnUpdateEvent(TEntity item)
        {
            EntryUpdateEventHandler<TEntity> handler = UpdateEvent;
            handler?.Invoke(this, new EntryEventArgs<TEntity>(item));
        }
        protected virtual void OnDeleteEvent(TEntity item)
        {
            EntryDeleteEventHandler<TEntity> handler = DeleteEvent;
            handler?.Invoke(this, new EntryEventArgs<TEntity>(item));
        }
        protected virtual void OnSaveEvent(TEntity item)
        {
            EntrySaveDataEventHandler<TEntity> handler = SaveEvent;
            handler?.Invoke(this, new EntryEventArgs<TEntity>(item));
        }
        protected virtual void OnCreateEventHandler(object sender, EntryEventArgs<TEntity> e)
        {
            Log.For(this).Info("New item of " + e.Item.GetType().Name + " model was created:\n" + e.Item.ToString());
        }
        protected virtual void OnUpdateEventHandler(object sender, EntryEventArgs<TEntity> e)
        {
            Log.For(this).Info("Item of " + e.Item.GetType().Name + " model was updated:\n" + e.Item.ToString());
        }
        protected virtual void OnDeleteEventHandler(object sender, EntryEventArgs<TEntity> e)
        {
            Log.For(this).Info("Item of " + e.Item.GetType().Name + " model was deleted:\n" + e.Item.ToString());
        }
        protected virtual void OnSaveEventHandler(object sender, EntryEventArgs<TEntity> e)
        {
            Log.For(this).Info("Data of " + e.Item.GetType().Name + " model was saved:\n" + e.Item.ToString());
        }
        */
    }

}