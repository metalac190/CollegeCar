using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] MainMenuRootUI _mainMenuRootUI = null;
    public MainMenuRootUI MainMenuRootUI => _mainMenuRootUI;

    [SerializeField] MainMenuSettingsUI _mainMenuSettingsUI = null;
    public MainMenuSettingsUI MainMenuSettingsUI => _mainMenuSettingsUI;
    
}
