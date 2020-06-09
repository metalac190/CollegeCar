using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayIntroState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayIntroState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("STATE: Gameplay Intro");
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }
}
