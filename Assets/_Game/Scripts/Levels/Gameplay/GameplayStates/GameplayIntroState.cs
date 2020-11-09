using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayIntroState : State
{
    GameplaySM _stateMachine = null;
    InputManager _input = null;

    public GameplayIntroState(GameplaySM stateMachine, InputManager input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public override void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Intro");
        //TODO play intro cutscene
        _input.Controls.Menu.Confirm.performed += ctx => OnConfirmPerformed();
        //_stateMachine.Input.OnMenuPress += HandleMenuPressed;
        //_stateMachine.Input.OnConfirmPress += HandleConfirmPressed;
    }

    public override void Exit()
    {
        _input.Controls.Menu.Confirm.performed -= ctx => OnConfirmPerformed();
        //_stateMachine.Input.OnMenuPress -= HandleMenuPressed;
        //_stateMachine.Input.OnConfirmPress -= HandleConfirmPressed;
    }

    public override void Tick()
    {

    }

    void OnConfirmPerformed()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayPlayingState);
    }
}
