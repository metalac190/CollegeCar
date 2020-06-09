using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayWinState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayWinState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("STATE: Win!");
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }
}
