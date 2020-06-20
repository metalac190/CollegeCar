using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuRootState : State
{
    MainMenuSM _stateMachine = null;
    PlayerInputHandler _input = null;
    MainMenuRootUIController _menuController = null;

    public MainMenuRootState(MainMenuSM stateMachine, PlayerInputHandler input, MainMenuRootUIController menuController)
    {
        _stateMachine = stateMachine;
        _input = input;
        _menuController = menuController;
    }

    public override void Enter()
    {
        Debug.Log("MAIN MENU STATE: Root");
        // input events
        //_input.OnUpPress += HandleUpPress;
        //_input.OnDownPress += HandleDownPress;
        //_input.OnConfirmPress += HandleConfirmPress;
        // button click events
        _menuController.OnStartGameClick += HandleStartGameClick;
        _menuController.OnSettingsClick += HandleSettingsClick;
        _menuController.OnQuitClick += HandleQuitClick;

        _menuController.ShowCanvas();
    }

    public override void Exit()
    {
        // input events
        //_input.OnUpPress -= HandleUpPress;
        //_input.OnDownPress -= HandleDownPress;
        //_input.OnConfirmPress -= HandleConfirmPress;
        // button click events
        _menuController.OnStartGameClick -= HandleStartGameClick;
        _menuController.OnSettingsClick -= HandleSettingsClick;
        _menuController.OnQuitClick -= HandleQuitClick;

        _menuController.HideCanvas();
    }

    public override void Tick()
    {
        
    }

    void HandleUpPress()
    {
        //TODO cycle button selection up
    }

    void HandleDownPress()
    {
        //TODO cycle button selection down
    }

    void HandleConfirmPress()
    {
        //TODO confirm Selection
    }

    void HandleStartGameClick()
    {
        _stateMachine.ChangeState(_stateMachine.StartGameState);
    }

    void HandleSettingsClick()
    {
        _stateMachine.ChangeState(_stateMachine.SettingsState);
    }

    void HandleQuitClick()
    {
        _stateMachine.ChangeState(_stateMachine.QuitState);
    }
}
