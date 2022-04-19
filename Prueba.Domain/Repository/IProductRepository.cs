﻿using System;
using System.Collections.Generic;

namespace Prueba.Domain.Repository
{
    public interface IProductRepository
    {
        public void Save(Entity.Product product);
        public void Edit(Entity.Product product);
        public Entity.Product GetById(int productId);
        public ICollection<Entity.Product> GetAll();
    }
}
