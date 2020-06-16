using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuQuitState : State
{
    MainMenuSM _stateMachine = null;

    public MainMenuQuitState(MainMenuSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        //TODO handle any exit logic, saving, etc.
        Application.Quit();
    }

    public override void Exit()
    {
        
    }

    public override void Tick()
    {
        
    }
}
