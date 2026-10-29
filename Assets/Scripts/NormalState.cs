using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NormalState : State
{
    
    
    public NormalState(Player player, StateMachine machine) : base(player, machine)
    {
    }

    // Start is called before the first frame update
    public override void Enter()
    {
        base.Enter();
        player.speed = 4.5f;
        
    }
    public override void Exit()
    {
        base.Exit();
    }
    // Update is called once per frame
    public override void FixedUpdate()
    {
        if (player.wasSNow && !player.wasSLast)
        {
            if (machine.currentState != player.slowState)
            {
                machine.ChangeState(player.slowState);
            }
        }
        player.rb.velocity = new Vector2(player.direction.x,player.direction.y)*player.speed;
        
        
    }
}
