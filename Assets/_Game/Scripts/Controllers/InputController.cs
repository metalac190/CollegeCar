using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{
    //TODO convert to Get Axis
    public event Action OnUpPress = delegate { };
    public event Action OnDownPress = delegate { };
    public event Action OnLeftPress = delegate { };
    public event Action OnRightPress = delegate { };

    public event Action OnConfirmPress = delegate { };  // Space by default
    public event Action OnCancelPress = delegate { };   // Backspace by default
    public event Action OnMenuPress = delegate { };     // Escape by default
    public event Action OnSpecial01Press = delegate { };  // O by default
    public event Action OnSpecial02Press = delegate { };    // P by default

    private void Update()
    {
        // Movement
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnLeftPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnRightPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnUpPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            OnDownPress.Invoke();
        }
        // Confirm/Cancel Actions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnConfirmPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            OnCancelPress.Invoke();
        }
        // Ability Actions
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnMenuPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            OnSpecial01Press.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnSpecial02Press.Invoke();
        }
    }
}
