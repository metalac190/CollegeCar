using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[RequireComponent(typeof(MainMenuSettingsUIView))]
public class MainMenuSettingsUIController : UIController
{
    public event Action OnBackButtonClick;

    [Header("Settings Controller")]
    [SerializeField] Button _backButton = null;

    MainMenuSettingsUIView _view = null;

    private void Awake()
    {
        _view = GetComponent<MainMenuSettingsUIView>();
    }

    private void OnEnable()
    {
        _backButton.onClick.AddListener(HandleBackButtonPress);
    }

    private void OnDisable()
    {
        _backButton.onClick.RemoveListener(HandleBackButtonPress);
    }

    public override void HideCanvas()
    {
        _view.Hide();
    }

    public override void ShowCanvas()
    {
        _view.Show();
    }

    void HandleBackButtonPress()
    {
        OnBackButtonClick?.Invoke();
    }
}
