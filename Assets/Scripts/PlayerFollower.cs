using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : Follower
{
    

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        bSpawn = gameObject.GetComponent<BSpawnPoint>();

    }
    
    
    protected override void Start()
    {
        center = Player.Instance.transform;
        base.Start();
        
    }

    // Update is called once per frame
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        if (Input.GetKey(KeyCode.Z))
        {
            if (bSpawn == null) return;
            bSpawn.Shoot();
        }
    }
}
