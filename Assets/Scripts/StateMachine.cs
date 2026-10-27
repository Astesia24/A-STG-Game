using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    Player player;
    State currentState;
    public StateMachine(Player player)
    {
        this.player = player;
    }
    public void Initialize(State oriState)
    {
        currentState = oriState;
        currentState.Enter();
    }
    public void ChangeState(State newState)
    {
        if(currentState!=null)
        {
            currentState.Exit();
        }
        else
        {
            Debug.Log("盲猜没初始化");
        }
        currentState = newState;
        currentState.Enter();
    }

    
    public void Update()
    {
        currentState.Update();
    }
}
