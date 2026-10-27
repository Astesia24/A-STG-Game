using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected Player player;
    protected StateMachine machine;
    
    public State(Player player, StateMachine machine)
    {
        this.player = player;
        this.machine = machine;
    }
    public virtual void Enter()
    {
        if(player==null||machine==null)
        {
            Debug.Log("enter时plaer和machine有一个为空！");
        }
    }
    
    public virtual void Exit()
    {

    }
    
    

    // Update is called once per frame
    public virtual void Update()
    {
        
    }
}
