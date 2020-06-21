using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenuRootState : State
{
    MainMenuSM _stateMachine = null;
    PlayerControls _input = null;
    MainMenuRootUIController _menuController = null;

    public MainMenuRootState(MainMenuSM stateMachine, PlayerControls input, MainMenuRootUIController menuController)
    {
        _stateMachine = stateMachine;
        _input = input;
        _menuController = menuController;
    }

    public override void Enter()
    {
        Debug.Log("MAIN MENU STATE: Root");
        // input events
        _input.Menu.Up.performed += ctx => HandleUpPerformed();
        _input.Menu.Down.performed += ctx => HandleDownPerformed();
        _input.Menu.Confirm.performed += ctx => HandleConfirmPress();
        // button click events
        _menuController.OnStartGameClick += HandleStartGameClick;
        _menuController.OnSettingsClick += HandleSettingsClick;
        _menuController.OnQuitClick += HandleQuitClick;

        _menuController.ShowCanvas();
    }

    public override void Exit()
    {
        // input events
        _input.Menu.Up.performed -= ctx => HandleUpPerformed();
        _input.Menu.Down.performed -= ctx => HandleDownPerformed();
        _input.Menu.Confirm.performed -= ctx => HandleConfirmPress();
        // button click events
        _menuController.OnStartGameClick -= HandleStartGameClick;
        _menuController.OnSettingsClick -= HandleSettingsClick;
        _menuController.OnQuitClick -= HandleQuitClick;

        _menuController.HideCanvas();
    }

    public override void Tick()
    {
        
    }

    void HandleUpPerformed()
    {
        Debug.Log("Pressed UP");
    }

    void HandleDownPerformed()
    {
        Debug.Log("Pressed DOWN");
    }

    void HandleConfirmPress()
    {
        Debug.Log("Pressed CONFIRM");
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
