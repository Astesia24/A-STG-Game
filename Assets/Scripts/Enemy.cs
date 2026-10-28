using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //基础属性
    public float maxHp;
    public float Hp;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float att)
    {
        Hp -= att;
        if(Hp<=0)
        {
            Die();
        }
    }
    protected void Die()
    {
        //待补全




        gameObject.SetActive(false);
    }
}
