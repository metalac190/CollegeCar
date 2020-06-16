using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayExitState : State
{
    GameplaySM _stateMachine = null;

    public GameplayExitState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Exit");
    }

    public override void Exit()
    {
        
    }

    public override void Tick()
    {
        //TODO load a different level here
    }
}
