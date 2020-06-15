using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayExitState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayExitState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Exit");
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        //TODO load a different level here
    }
}
