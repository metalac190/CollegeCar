using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// This class is responsible for controlling the UI Menu States and events
/// related to the MainMenuRoot state.
/// </summary>
public class MainMenuRootUIController : UIController
{
    // button events
    public event Action OnStartGameClick = delegate { };
    public event Action OnSettingsClick = delegate { };
    public event Action OnQuitClick = delegate { };

    [Header("View")]
    [SerializeField] MainMenuRootView _rootView = null; // offloading display functions to a 'View' script for this UI

    [Header("Buttons")]
    [SerializeField] Button _startGameButton = null;
    [SerializeField] Button _settingsButton = null;
    [SerializeField] Button _quitButton = null;

    private void OnEnable()
    {
        // menu events
        _rootView.OnMenuHidden += HandleMenuHidden;
        // button click events
        _startGameButton.onClick.AddListener(HandleStartGameButtonPress);
        _settingsButton.onClick.AddListener(HandleSettingsButtonPress);
        _quitButton.onClick.AddListener(HandleQuitButtonPress);
    }

    private void OnDisable()
    {
        // menu events
        _rootView.OnMenuHidden -= HandleMenuHidden;
        // button click events
        _startGameButton.onClick.RemoveListener(HandleStartGameButtonPress);
        _settingsButton.onClick.RemoveListener(HandleSettingsButtonPress);
        _quitButton.onClick.RemoveListener(HandleQuitButtonPress);
    }

    public override void ShowCanvas()
    {
        _rootView.gameObject.SetActive(true);
        _rootView.Show();
    }

    public override void HideCanvas()
    {
        _rootView.Hide();
    }

    public void UpdateDisplay()
    {
        // Example: can update data here if necessary
    }

    #region Callbacks
    void HandleMenuHidden()
    {
        _rootView.gameObject.SetActive(false);
    }
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
