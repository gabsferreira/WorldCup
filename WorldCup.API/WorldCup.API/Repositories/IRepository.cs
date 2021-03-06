﻿using System;

namespace WorldCup.API.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        void Save(T cup);
    }
}