using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{
    public event Action OnConfirmPress = delegate { };  // Space by default
    public event Action OnMenuPress = delegate { };     // Escape by default
    public event Action OnSpecial01Press = delegate { };  // O by default
    public event Action OnSpecial02Press = delegate { };    // P by default

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnConfirmPress.Invoke();
        }
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
