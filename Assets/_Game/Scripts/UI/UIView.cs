using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class UIView : MonoBehaviour
{
    public event Action OnMenuHidden;

    [Header("Base Settings")]
    [SerializeField] PanelAnimationSimple _menuAnimation = null;

    private void OnEnable()
    {
        _menuAnimation?.OnHideAnimationComplete.AddListener(OnMenuHidden.Invoke);
    }

    private void OnDisable()
    {
        _menuAnimation?.OnHideAnimationComplete.RemoveListener(OnMenuHidden.Invoke);
    }

    public virtual void Show()
    {
        _menuAnimation?.AnimateShow();
    }

    public virtual void Hide()
    {
        _menuAnimation?.AnimateHide();
    }
}
