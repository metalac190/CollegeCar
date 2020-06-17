using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class UIView : MonoBehaviour
{
    [Header("Base Settings")]
    [SerializeField] Canvas _menuCanvas = null;
    protected Canvas MenuCanvas => _menuCanvas;

    [SerializeField] MenuAnimation _menuAnimation = null;

    private void OnEnable()
    {
        if(_menuAnimation != null)
        {
            _menuAnimation.OnHideComplete += HandleHideComplete;
        }
    }

    private void OnDisable()
    {
        if(_menuAnimation != null)
        {
            _menuAnimation.OnHideComplete -= HandleHideComplete;
        }
    }

    public virtual void Show()
    {
        // make sure the Canvas is enabled
        _menuCanvas.gameObject.SetActive(true);

        if(_menuAnimation != null)
        {
            _menuAnimation.AnimateShow();
        }
    }

    public virtual void Hide()
    {
        // if there's no hide animation, just disable it
        if(_menuAnimation != null)
        {
            _menuAnimation.AnimateHide();
        }
        else
        {
            _menuCanvas.gameObject.SetActive(false);
        }
    }

    void HandleHideComplete()
    {
        _menuCanvas.gameObject.SetActive(false);
    }
}
