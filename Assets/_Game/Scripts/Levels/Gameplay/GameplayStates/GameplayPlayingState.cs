using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayPlayingState : State
{
    GameplaySM _stateMachine = null;

    public GameplayPlayingState(GameplaySM stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void Enter()
    {
        Debug.Log("GAMEPLAY STATE: Playing");
        //_stateMachine.Input.OnMenuPress += HandleMenuPress;
        //TODO replace this test button press with a trigger volume or condition event
        //_stateMachine.Input.OnSpecial01Press += HandleSpecial01Press;
        //_stateMachine.Input.OnSpecial02Press += HandleSpecial02Press;
    }

    public override void Exit()
    {
        //_stateMachine.Input.OnMenuPress -= HandleMenuPress;
        //_stateMachine.Input.OnSpecial01Press -= HandleSpecial01Press;
        //_stateMachine.Input.OnSpecial02Press -= HandleSpecial02Press;
    }

    public override void Tick()
    {
        
    }

    void HandleMenuPress()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayPauseMenuState);
    }

    void HandleSpecial01Press()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayWinState);
    }

    void HandleSpecial02Press()
    {
        _stateMachine.ChangeState(_stateMachine.GameplayLoseState);
    }
}
