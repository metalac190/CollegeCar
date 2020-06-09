using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPauseState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayPauseState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("STATE: Paused");
    }

    public void Exit()
    {
        Debug.Log("STATE: Unpaused");
    }

    public void Tick()
    {
        
    }
}
