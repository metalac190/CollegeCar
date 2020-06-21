using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenuSM : StateMachine
{
    [SerializeField] InputManager _input = null;
    [SerializeField] MainMenuUIManager _uIManager = null;

    public MainMenuRootState RootState { get; private set; }
    public MainMenuSettingsState SettingsState { get; private set; }
    public MainMenuQuitState QuitState { get; private set; }
    public MainMenuStartGameState StartGameState { get; private set; }

    private void Awake()
    {
        RootState = new MainMenuRootState(this, _input.Controls, _uIManager.MainMenuRootUI);
        SettingsState = new MainMenuSettingsState(this, _input.Controls, _uIManager.MainMenuSettingsUI);
        QuitState = new MainMenuQuitState(this);
        StartGameState = new MainMenuStartGameState(this);
    }

    private void Start()
    {
        ChangeState(RootState);
    }
}
