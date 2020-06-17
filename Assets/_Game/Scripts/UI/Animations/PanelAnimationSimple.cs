using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

[RequireComponent(typeof(RectTransform))]
public class PanelAnimationSimple : MenuAnimation
{
    [Header("General Settings")]
    [SerializeField] CanvasGroup _canvasGroup = null;
    [SerializeField] RectTransform _panelToAnimate = null;

    [Header("Animation In Settings")]
    [SerializeField] float _animateInTime = .5f;
    [SerializeField] Vector3 _startInScale = new Vector3(.5f, .5f, .5f);
    [Range(0,1)][SerializeField] float _startFade = 0;
    
    [Header("Animation Out Settings")]
    [SerializeField] float _animateOutTime = .25f;
    [SerializeField] Vector3 _endOutScale = new Vector3(.5f, .5f, .5f);
    [Range(0, 1)] [SerializeField] float _endFade = 0;

    [Header("Animation Events")]
    public UnityEvent OnShowAnimationComplete;
    public UnityEvent OnHideAnimationComplete;

    Vector3 _initialScale;

    void Awake()
    {
        _initialScale = _panelToAnimate.localScale;
        Debug.Log(_initialScale);
        if(_canvasGroup == null || _panelToAnimate == null)
        {
            Debug.Log("Missing required Inspector references on panel animation", this);
        }
    }

    public override void AnimateShow()
    {
        Debug.Log("Show Root Menu");
        // initialize animation start state
        _panelToAnimate.localScale = _startInScale;
        _canvasGroup.alpha = _startFade;
        // animate in
        _panelToAnimate.DOScale(_initialScale, _animateInTime);
        _canvasGroup.DOFade(1, _animateInTime).OnComplete(OnShowAnimationComplete.Invoke);
    }

    public override void AnimateHide()
    {
        Debug.Log("Hide Root Menu");
        // initialize animation out state
        _panelToAnimate.localScale = _initialScale;
        _canvasGroup.alpha = 1;
        // animate out
        _panelToAnimate.DOScale(_endOutScale, _animateOutTime);
        _canvasGroup.DOFade(_endFade, _animateOutTime).OnComplete(OnHideAnimationComplete.Invoke);
    }
}
