using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuStartGameState : State
{
    MainMenuSM _stateMachine = null;
    const string _levelName = "GameSceneDEV";

    public MainMenuStartGameState(MainMenuSM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        // load the level
        SceneLoader.LoadScene(_levelName);
    }

    public override void Exit()
    {
        
    }

    public override void Tick()
    {
        
    }
}
