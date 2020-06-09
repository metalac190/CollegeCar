using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySM : StateMachine
{
    // states
    public GameplayIntroState GameplayIntroState { get; private set; }
    public GameplayPauseState GameplayPauseState { get; private set; }
    public GameplayPlayingState GameplayPlayingState { get; private set; }

    private void Start()
    {
        ChangeState(GameplayIntroState);
    }
}
