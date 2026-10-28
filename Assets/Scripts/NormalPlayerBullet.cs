using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlayerBullet : PlayerBullet
{
    // Start is called before the first frame update
    public override void Awake()
    {
        base.Awake();
        OriHp = 5;
        SSpeed = 14f;
        Sdamage = 1f;
    }
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void FixedUpdate()
    {
        
        CurrentDir = Vector2.up;
        base.FixedUpdate();
        CurrentDir = Vector2.up;
        //此处写两遍currentDir，第一处是为了防止因为时序问题空引用报错，第二处是因为基类里面又定义了currentSpeed，有点繁琐，可能需要尝试优化
        rb.velocity = CurrentDir * CurSpeed;
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D (collision);
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy == null) return;
        enemy.TakeDamage(Sdamage);
        Die();
    }
    public override void Spawn()
    {
        base.Spawn();


    }
    public override void Die()
    {
        base.Die();


    }
}
