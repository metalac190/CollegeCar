using System;
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
        Debug.Log("GAMEPLAY STATE: Intro");
        //TODO play intro cutscene
        _stateMachine.Input.OnMenuPress += HandleMenuPressed;
        _stateMachine.Input.OnConfirmPress += HandleConfirmPressed;
    }

    public void Exit()
    {
        _stateMachine.Input.OnMenuPress -= HandleMenuPressed;
        _stateMachine.Input.OnConfirmPress -= HandleConfirmPressed;
    }

    public void Tick()
    {

    }

    private void HandleConfirmPressed()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayPlayingState);
    }

    void HandleMenuPressed()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayPlayingState);
    }
}
