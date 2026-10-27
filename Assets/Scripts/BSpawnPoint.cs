using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSpawnPoint : MonoBehaviour
{
    //这是最普通的生成点
    public GameObject prefab;
    public float Interval;
    

    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = -1f;
        Interval = 1.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer<=0)
        {
            ObjectPoolManager.Instance.FetchOne(prefab,(Vector2)transform.position);
            Timer = Interval;
        }
        if(Timer>0)
        {
            Timer -= Time.deltaTime;
        }
    }
}
