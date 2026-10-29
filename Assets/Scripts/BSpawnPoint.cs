using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSpawnPoint : MonoBehaviour
{
    //这是最普通的生成点
    public GameObject prefab;
    public float Interval;
    public float nextShoot;

    
    // Start is called before the first frame update
    void Start()
    {
        
        Interval = 0.1f;
        nextShoot = 0f;
    }

    // Update is called once per frame
    public void Shoot()
    {
        if(Time.time>=nextShoot)
        {
            ObjectPoolManager.Instance.FetchOne(prefab,(Vector2)transform.position);
            nextShoot = Time.time+Interval;
        }
        
    }
}
