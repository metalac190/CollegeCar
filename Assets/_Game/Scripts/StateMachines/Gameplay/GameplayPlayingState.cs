using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPlayingState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayPlayingState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("STATE: Playing Level");
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }
}
