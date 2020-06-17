using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] MainMenuRootUIController _mainMenuRootUI = null;
    public MainMenuRootUIController MainMenuRootUI => _mainMenuRootUI;

    [SerializeField] MainMenuSettingsUIController _mainMenuSettingsUI = null;
    public MainMenuSettingsUIController MainMenuSettingsUI => _mainMenuSettingsUI;
    
}
