using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainMenuRootUI : MonoBehaviour
{
    // button events
    public event Action OnStartGameClick = delegate { };
    public event Action OnSettingsClick = delegate { };
    public event Action OnQuitClick = delegate { };
    [Header("Views")]
    [SerializeField] MainMenuRootView _rootView = null;
    [Header("Buttons")]
    [SerializeField] Button _startGameButton = null;
    [SerializeField] Button _settingsButton = null;
    [SerializeField] Button _quitButton = null;

    private void OnEnable()
    {
        _startGameButton.onClick.AddListener(HandleStartGameButtonPress);
        _settingsButton.onClick.AddListener(HandleSettingsButtonPress);
        _quitButton.onClick.AddListener(HandleQuitButtonPress);
    }

    private void OnDisable()
    {
        _startGameButton.onClick.RemoveListener(HandleStartGameButtonPress);
        _settingsButton.onClick.RemoveListener(HandleSettingsButtonPress);
        _quitButton.onClick.RemoveListener(HandleQuitButtonPress);
    }

    private void Awake()
    {
        // default it to disabled
        _rootView.gameObject.SetActive(false);
    }

    public void Show()
    {
        //TODO animate in
        _rootView.gameObject.SetActive(true);
        _rootView.Show();
    }

    public void UpdateDisplay()
    {
        // can update data here if necessary
    }

    public void Hide()
    {
        //TODO animate out
        _rootView.Hide();
    }

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
}
