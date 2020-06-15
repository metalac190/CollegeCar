using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLoseState : IState
{
    GameplaySM _stateMachine = null;

    public GameplayLoseState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Lose");
        _stateMachine.Input.OnConfirmPress += HandleConfirmPress;
    }

    public void Exit()
    {
        _stateMachine.Input.OnConfirmPress -= HandleConfirmPress;
    }

    private void HandleConfirmPress()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayExitState);
    }

    public void Tick()
    {

    }
}
