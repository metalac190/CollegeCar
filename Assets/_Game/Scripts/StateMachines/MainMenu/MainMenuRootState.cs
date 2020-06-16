using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuRootState : IState
{
    MainMenuSM _stateMachine = null;
    InputController _input = null;

    public MainMenuRootState(MainMenuSM stateMachine, InputController input)
    {
        _stateMachine = stateMachine;
        _input = input;
    }

    public void Enter()
    {
        
    }

    public void Exit()
    {
        
    }

    public void Tick()
    {
        
    }
}
