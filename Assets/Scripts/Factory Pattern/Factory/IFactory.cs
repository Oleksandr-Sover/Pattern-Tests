using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public interface IFactory<T> where T : Object
    {
        public abstract List<T> objects { get; }
        public abstract T Create(T original);
        public abstract void Destroy(T objectToDestroy);
    }
}