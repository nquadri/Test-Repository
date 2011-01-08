using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace TestApp
{
    /// <summary>
    /// ObjectSetExtensions
    /// </summary>
    public static class ObjectSetExtensions
    {
        public static void AddRoot<T>(this ObjectSet<T> objectSet, T entity) where T : class
        {
            objectSet.AddObject(entity);
        }

        public static void Add<T>(this ObjectSet<T> objectSet, T newEntity) where T : class
        {
            ObjectContext context = objectSet.Context;

            string entitySetName = objectSet.EntitySet.Name;
            EntityKey key = context.CreateEntityKey(entitySetName, newEntity);

            object entity;
            if (context.TryGetObjectByKey(key, out entity))
            {
                objectSet.ApplyCurrentValues(newEntity);
                context.ObjectStateManager.ChangeObjectState(entity, EntityState.Added);
            }
            else
            {
                objectSet.AddObject(newEntity);
            }
        }

        public static void ModifyRoot<T>(this ObjectSet<T> objectSet, T entity) where T : class
        {
            objectSet.Attach(entity);
            objectSet.Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
        }

        public static void Modify<T>(this ObjectSet<T> objectSet, T newEntity) where T : class
        {
            ObjectContext context = objectSet.Context;

            string entitySetName = objectSet.EntitySet.Name;
            EntityKey key = context.CreateEntityKey(entitySetName, newEntity);

            object entity;
            if (context.TryGetObjectByKey(key, out entity))
            {
                objectSet.ApplyCurrentValues(newEntity);
                context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
            }
            else
            {
                objectSet.Attach(newEntity);
                context.ObjectStateManager.ChangeObjectState(newEntity, EntityState.Modified);
            }
        }

        public static void DeleteRoot<T>(this ObjectSet<T> objectSet, T entity) where T : class
        {
            objectSet.Attach(entity);
            objectSet.Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);
        }

        public static void Delete<T>(this ObjectSet<T> objectSet, T newEntity) where T : class
        {
            ObjectContext context = objectSet.Context;

            string entitySetName = objectSet.EntitySet.Name;
            EntityKey key = context.CreateEntityKey(entitySetName, newEntity);

            object entity;
            if (context.TryGetObjectByKey(key, out entity))
            {
                context.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);
            }
        }
    }
}
