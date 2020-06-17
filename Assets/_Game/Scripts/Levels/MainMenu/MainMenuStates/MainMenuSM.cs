using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSM : StateMachine
{
    [SerializeField] InputController _input = null;
    [SerializeField] MainMenuUIManager _uIManager = null;

    public MainMenuRootState RootState { get; private set; }
    public MainMenuSettingsState SettingsState { get; private set; }
    public MainMenuQuitState QuitState { get; private set; }
    public MainMenuStartGameState StartGameState { get; private set; }

    private void Awake()
    {
        RootState = new MainMenuRootState(this, _input, _uIManager.MainMenuRootUI);
        SettingsState = new MainMenuSettingsState(this, _input, _uIManager.MainMenuSettingsUI);
        QuitState = new MainMenuQuitState(this);
        StartGameState = new MainMenuStartGameState(this);
    }

    private void Start()
    {
        ChangeState(RootState);
    }
}
