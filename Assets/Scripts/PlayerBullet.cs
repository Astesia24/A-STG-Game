using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    // Start is called before the first frame update
    
    public override void Awake()
    {
        base.Awake ();
    }
    public override void Start()
    {
        base.Start ();
    }

    // Update is called once per frame
    public override void FixedUpdate()
    {
        base.FixedUpdate ();
    }
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Enemy"))
        {
            return;
        }
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
