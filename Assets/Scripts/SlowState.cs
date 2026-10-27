using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowState : State
{
    public SlowState(Player player, StateMachine machine) : base(player, machine)
    {
    }

    // Start is called before the first frame update
    public override void Enter()
    {
        base.Enter();
        player.speed = 2f;
    }
    public override void Exit()
    {
        base.Exit();
    }
    // Update is called once per frame
    public override void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            machine.ChangeState(player.normalState);
        }
        else
        {
            player.rb.velocity = new Vector2(player.direction.x, player.direction.y) * player.speed;
        }
        
        
        
    }
}
