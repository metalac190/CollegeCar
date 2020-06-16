using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSM : StateMachine
{
    [SerializeField] InputController _input;

    public MainMenuRootState MainMenuRootState { get; private set; }
    public MainMenuSettingsState MainMenuSettingsState { get; private set; }

    private void Awake()
    {
        MainMenuRootState = new MainMenuRootState(this, _input);
        MainMenuSettingsState = new MainMenuSettingsState(this, _input);
    }

    private void Start()
    {
        ChangeState(MainMenuRootState);
    }
}
