using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAimBullet : Bullet
{
    // Start is called before the first frame update
    public override void Awake()
    {
        base.Awake();
        OriHp = 5;
        SSpeed = 3f;
        Sdamage = 20f;
    }
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        rb.velocity = StartDir*CurSpeed;
    }
    public override void Spawn()
    {
        base.Spawn();
        
        
    }
    public override void Die()
    {
        base.Die();
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player pp = collision.GetComponent<Player>();
            pp.Hp -= Curdamage;
            Die(); 
        }
    }
}
