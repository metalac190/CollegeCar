using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// This class is responsible for controlling the UI Menu States and events
/// related to the MainMenuRoot state.
/// </summary>

[RequireComponent(typeof(MainMenuRootUIView))]
public class MainMenuRootUIController : UIController
{
    // button events
    public event Action OnStartGameClick = delegate { };
    public event Action OnSettingsClick = delegate { };
    public event Action OnQuitClick = delegate { };

    [Header("Root Controller")]
    [SerializeField] Button _startGameButton = null;
    [SerializeField] Button _settingsButton = null;
    [SerializeField] Button _quitButton = null;

    MainMenuRootUIView _view = null; // offloading display functions to a 'View' script for this UI

    private void Awake()
    {
        _view = GetComponent<MainMenuRootUIView>();
    }

    private void OnEnable()
    {
        // menu events
        //_view.OnMenuHidden += HandleMenuHidden;
        // button click events
        _startGameButton.onClick.AddListener(HandleStartGameButtonPress);
        _settingsButton.onClick.AddListener(HandleSettingsButtonPress);
        _quitButton.onClick.AddListener(HandleQuitButtonPress);
    }

    private void OnDisable()
    {
        // menu events
        //_view.OnMenuHidden -= HandleMenuHidden;
        // button click events
        _startGameButton.onClick.RemoveListener(HandleStartGameButtonPress);
        _settingsButton.onClick.RemoveListener(HandleSettingsButtonPress);
        _quitButton.onClick.RemoveListener(HandleQuitButtonPress);
    }

    public override void ShowCanvas()
    {
        _view.Show();
    }

    public override void HideCanvas()
    {
        _view.Hide();
    }

    public void UpdateDisplay()
    {
        // Example: can update data here if necessary
    }

    #region Callbacks
    // example for how to do button events
    void HandleStartGameButtonPress()
    {
        OnStartGameClick?.Invoke();
    }

    void HandleSettingsButtonPress()
    {
        OnSettingsClick?.Invoke();
    }

    void HandleQuitButtonPress()
    {
        OnQuitClick?.Invoke();
    }


    #endregion
}
