using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenuSettingsState : State
{
    MainMenuSM _stateMachine = null;
    PlayerControls _input = null;
    MainMenuSettingsUIController _uiController = null;

    public MainMenuSettingsState(MainMenuSM stateMachine, PlayerControls input, MainMenuSettingsUIController uiController)
    {
        _stateMachine = stateMachine;
        //_input = input;
        _uiController = uiController;
    }

    public override void Enter()
    {
        Debug.Log("MAIN MENU STATE: Settings");
        _uiController.ShowCanvas();

        _uiController.OnBackButtonClick += HandleBackButtonClick;
    }

    public override void Exit()
    {
        _uiController.HideCanvas();
        
        _uiController.OnBackButtonClick -= HandleBackButtonClick;
    }

    public override void Tick()
    {
        
    }

    void HandleBackButtonClick()
    {
        _stateMachine.ChangeState(_stateMachine.RootState);
    }
}
