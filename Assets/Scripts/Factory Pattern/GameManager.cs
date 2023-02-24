using UnityEngine;

namespace FactoryPattern
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        GameObject prefab_A;
        [SerializeField]
        GameObject prefab_B;

        IFactory<GameObject> goFactory_A;
        IFactory<GameObject> goFactory_B;

        GameObject go;

        [SerializeField]
        float time;
        float timer;

        void Start()
        {
            goFactory_A = new GameObjectFactory();
            goFactory_B = new GameObjectFactory();
        }

        void Update()
        {
            if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                timer = time;

                go = goFactory_A.Create(prefab_A);
                go.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
                Debug.Log("Create " + prefab_A.name);
                go = goFactory_B.Create(prefab_B);
                go.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
                Debug.Log("Create " + prefab_B.name);
            }
        }
    }
}