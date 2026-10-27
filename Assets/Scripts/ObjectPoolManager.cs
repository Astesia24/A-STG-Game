using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager Instance;
    //配置
    [System.Serializable]
    public class Config
    {
        public GameObject prefab;
        public int prewarmN;
        public int maxCountN;
    }
    public List<Config> configs;


    public List<ObjectPool> pools = new List<ObjectPool>();
    private void Awake()
    {
        Instance = this;
        if (configs == null) return;
        
        for (int i =0;i<configs.Count;i++)
        {
            if (configs[i].prefab == null)
            {
                Debug.LogWarning("EnemyPoolManager: 第 " + i + " 条配置没有拖 prefab");
                continue;
            }
            ObjectPool ppool = new ObjectPool(configs[i].prefab, configs[i].prewarmN, configs[i].maxCountN);
            pools.Add(ppool);
        }





    }

    public void FetchOne(GameObject oobject,Vector2 pos)
    {
        for(int i=0;i<pools.Count;i++)
        {
            if (pools[i].prefab == oobject)
            {
                pools[i].Fetch(pos);
                return;
            }
            else
            {
                continue;
            }
        }
    }
    public void ReturnOne(GameObject oobject)
    {
        for(int i =0;i<pools.Count;i++)
        {
            if (pools[i].checklists.Contains(oobject))
            {
                pools[i]?.Return(oobject);
                
                return;
            }
            else
            {
                continue;
            }
        }
    }





}
