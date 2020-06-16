using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSettingsState : IState
{
    MainMenuSM _stateMachine = null;
    InputController _input = null;

    public MainMenuSettingsState(MainMenuSM stateMachine, InputController input)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Tick()
    {
        throw new System.NotImplementedException();
    }
}
