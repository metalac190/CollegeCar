using System;
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
        Debug.Log("GAMEPLAY STATE: Win!");
        _stateMachine.Input.OnConfirmPress += HandleConfirmPress;
    }

    public void Exit()
    {
        _stateMachine.Input.OnConfirmPress -= HandleConfirmPress;
    }

    public void Tick()
    {
        
    }

    private void HandleConfirmPress()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayExitState);
        //TODO reload level
        Debug.Log("Application end!");
    }
}
