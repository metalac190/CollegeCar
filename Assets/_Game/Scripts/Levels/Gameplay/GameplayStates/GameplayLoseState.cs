using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLoseState : State
{
    GameplaySM _stateMachine = null;

    public GameplayLoseState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Lose");
        _stateMachine.Input.OnConfirmPress += HandleConfirmPress;
    }

    public override void Exit()
    {
        _stateMachine.Input.OnConfirmPress -= HandleConfirmPress;
    }

    public override void Tick()
    {

    }

    private void HandleConfirmPress()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayExitState);
    }
}
