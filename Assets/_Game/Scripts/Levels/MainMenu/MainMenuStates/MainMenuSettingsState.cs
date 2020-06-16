using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSettingsState : State
{
    MainMenuSM _stateMachine = null;
    InputController _input = null;

    public MainMenuSettingsState(MainMenuSM stateMachine, InputController input)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        throw new System.NotImplementedException();
    }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }

    public override void Tick()
    {
        throw new System.NotImplementedException();
    }
}
