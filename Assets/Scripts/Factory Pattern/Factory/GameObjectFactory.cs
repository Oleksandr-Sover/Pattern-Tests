using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern
{
    public class GameObjectFactory : IFactory<GameObject>
    {
        public List<GameObject> objects { get => GOPool.ActiveGO; }

        readonly IGameObjectPool GOPool = new GameObjectPool();

        public GameObject Create(GameObject prefab)
        {
            if (GOPool.DeactiveGOPoolCount > 0)
            {
                GameObject go = GOPool.PullOutDisableGO();
                GOPool.EnableGO(go);
                return go;
            }
            else
            {
                GameObject go = Object.Instantiate(prefab);
                GOPool.EnableGO(go);
                return go;
            }
        }
        public void Destroy(GameObject objectToDestroy) => GOPool.DisableGO(objectToDestroy);
    }
}