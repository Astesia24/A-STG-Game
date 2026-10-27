using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{



    public Queue<GameObject> objects = new Queue<GameObject>();
    //用于查找所属的列表
    public List<GameObject> checklists = new List<GameObject>();

    public GameObject prefab;
    public int _prewarm;
    public int _maxCount;
    public int totalCount = 0;

    public ObjectPool(GameObject pref,int prewarm,int maxCount)
    {
        prefab = pref;
        _prewarm = prewarm;
        _maxCount = maxCount;
        //预热
        for (int i = 0; i < _prewarm; i++)
        {
            GameObject hot;
            hot = Create();
            if(hot== null)
            {
                break;
            }
            hot.SetActive(false);
            objects.Enqueue(hot);
        }
    }
    // Start is called before the first frame update
    
    public GameObject Fetch(Vector2 pos)
    {
        GameObject aimone;
        if(objects.Count > 0)
        {
            aimone = objects.Dequeue();
        }
        else
        {
            aimone = Create();
            if(aimone != null)
            {
                return aimone;
            }
            else
            {
                return null;
            }
        }
        aimone.transform.position = pos;
        aimone.transform.SetParent(null);
        aimone.SetActive(true);
        Bullet bullet = aimone.GetComponent<Bullet>();
        if(bullet!=null)
        {
            bullet.Spawn();
        }
        //此处else后续如果不止bullet用池应该还会改
        else
        {
            return null;
        }
        return aimone;
    }
    public GameObject Create()
    {
        if(totalCount<_maxCount)
        {
            GameObject oobject = Object.Instantiate(prefab);
            
            totalCount++;
            checklists.Add(oobject);
            oobject.transform.SetParent(null);
            return oobject;
        }
        else
        {
            return null;
        }
    }
    public void Return(GameObject oobject)
    {
        if (oobject == null) return;
        objects.Enqueue(oobject);
    }

}
