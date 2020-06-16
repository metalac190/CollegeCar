using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainMenuRootView : MonoBehaviour
{
    Coroutine _viewRoutine = null;

    public void Show()
    {
        if (_viewRoutine != null)
            StopCoroutine(_viewRoutine);
        _viewRoutine = StartCoroutine(ShowRoutine());
    }

    public IEnumerator ShowRoutine()
    {
        yield return null;
    }

    public void UpdateDisplay()
    {

    }

    public void Hide()
    {
        if (_viewRoutine != null)
            StopCoroutine(_viewRoutine);
        _viewRoutine = StartCoroutine(HideRoutine());
    }

    public IEnumerator HideRoutine()
    {
        yield return null;
        gameObject.SetActive(false);
    }
}
