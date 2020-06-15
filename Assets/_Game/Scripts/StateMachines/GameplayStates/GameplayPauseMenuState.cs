using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPauseMenuState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayPauseMenuState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Paused");
        _stateMachine.Input.OnMenuPress += HandleMenuPress;
    }

    public void Exit()
    {
        _stateMachine.Input.OnMenuPress -= HandleMenuPress;
    }

    public void Tick()
    {
        
    }
    
    void HandleMenuPress()
    {
        _stateMachine.ChangeToPreviousState();
    }
}
