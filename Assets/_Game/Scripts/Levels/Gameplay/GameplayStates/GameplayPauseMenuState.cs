using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPauseMenuState : State
{
    GameplaySM _stateMachine = null;

    public GameplayPauseMenuState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Paused");
        _stateMachine.Input.OnMenuPress += HandleMenuPress;
    }

    public override void Exit()
    {
        _stateMachine.Input.OnMenuPress -= HandleMenuPress;
    }

    public override void Tick()
    {
        
    }
    
    void HandleMenuPress()
    {
        _stateMachine.ChangeToPreviousState();
    }
}
