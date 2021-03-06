﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Business
{
   public interface IEntityService <T> where T: class , IEntity,new()
   {
       void Add(T entity);
       void Update(T entity);
       void Delete(T entity);
       List<T> GetAll();
       T GetById(int id);

   }
}
