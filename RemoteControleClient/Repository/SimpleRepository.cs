using RemoteControleClient.DataBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControleClient.Repository
{
    public static class DbContextExtensions
    {
        public static string[] GetKeyNames<TEntity>(this DbContext context)
            where TEntity : class
        {
            return context.GetKeyNames(typeof(TEntity));
        }

        public static string[] GetKeyNames(this DbContext context, Type entityType)
        {
            var metadata = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;

            var objectItemCollection = ((ObjectItemCollection)metadata.GetItemCollection(DataSpace.OSpace));

            var entityMetadata = metadata
                    .GetItems<EntityType>(DataSpace.OSpace)
                    .Single(e => objectItemCollection.GetClrType(e) == entityType);

            return entityMetadata.KeyProperties.Select(p => p.Name).ToArray();
        }
        public static void Assign(this object destination, object source)
        {
            if (destination is IEnumerable && source is IEnumerable)
            {
                var dest_enumerator = (destination as IEnumerable).GetEnumerator();
                var src_enumerator = (source as IEnumerable).GetEnumerator();
                while (dest_enumerator.MoveNext() && src_enumerator.MoveNext())
                    dest_enumerator.Current.Assign(src_enumerator.Current);
            }
            else
            {
                var destProperties = destination.GetType().GetProperties();
                foreach (var sourceProperty in source.GetType().GetProperties())
                {
                    foreach (var destProperty in destProperties)
                    {
                        if (destProperty.Name == sourceProperty.Name && destProperty.PropertyType.IsAssignableFrom(sourceProperty.PropertyType))
                        {
                            destProperty.SetValue(destination,
                                sourceProperty.GetValue(source, new object[] { }), new object[] { });
                            break;
                        }
                    }
                }
            }
        }
    }
    public abstract class SimpleRepository<T> : ISimpleRepository<T> where T : class, new()
    {

        protected NettworkSettingsEntities _context;
        public virtual NettworkSettingsEntities context
        {
            get { return _context ?? (_context = new NettworkSettingsEntities()); }
        }
        protected abstract DbSet<T> dbSet { get; }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public void Save(T obj)
        {
            string[] keys = context.GetKeyNames<T>();
            object propertyValue = obj.GetType().GetProperty(keys[0]).GetValue(obj, null);
            int val = Convert.ToInt32(propertyValue);
            if (val > 0)
            {
                T objSave = dbSet.Find(val);
                DbContextExtensions.Assign(objSave, obj);
            }
            else
            {
                dbSet.Attach(obj);
                dbSet.Add(obj);
            }
            context.SaveChanges();
        }

        public void Create(T obj)
        {
            dbSet.Attach(obj);
            dbSet.Add(obj);
            context.SaveChanges();
        }

        public void Delete(T obj)
        {
            string[] keys = context.GetKeyNames<T>();
            object propertyValue = obj.GetType().GetProperty(keys[0]).GetValue(obj, null);
            int val = Convert.ToInt32(propertyValue);
            T objDelete = dbSet.Find(val);
            dbSet.Remove(objDelete);
            context.SaveChanges();
        }
    }
}
