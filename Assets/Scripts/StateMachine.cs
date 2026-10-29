using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    
    public State currentState;
    
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

    
    public void FixedUpdate()
    {
        currentState.FixedUpdate();
        
    }
}
