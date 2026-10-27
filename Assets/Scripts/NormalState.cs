using System.Collections;
using System.Collections.Generic;
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
    public override void Update()
    {
        player.rb.velocity = new Vector2(player.direction.x,player.direction.y)*player.speed;
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            machine.ChangeState(player.slowState);
        }
    }
}
