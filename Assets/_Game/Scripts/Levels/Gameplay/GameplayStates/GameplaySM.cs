using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySM : StateMachine
{
    [SerializeField] PlayerInputHandler _input = null;
    public PlayerInputHandler Input => _input;
    // states
    public GameplayIntroState GameplayIntroState { get; private set; }
    public GameplayPauseMenuState GameplayPauseMenuState { get; private set; }
    public GameplayPlayingState GameplayPlayingState { get; private set; }
    public GameplayWinState GameplayWinState { get; private set; }
    public GameplayLoseState GameplayLoseState { get; private set; }
    public GameplayExitState GameplayExitState { get; private set; }

    private void Awake()
    {
        // create all the states
        GameplayIntroState = new GameplayIntroState(this);
        GameplayPauseMenuState = new GameplayPauseMenuState(this);
        GameplayPlayingState = new GameplayPlayingState(this);
        GameplayWinState = new GameplayWinState(this);
        GameplayLoseState = new GameplayLoseState(this);
        GameplayExitState = new GameplayExitState(this);
    }

    private void Start()
    {
        ChangeState(GameplayIntroState);
    }
}
