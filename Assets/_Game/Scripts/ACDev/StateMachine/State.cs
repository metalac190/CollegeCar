using System.Collections;
using System;

public abstract class State
{
    // automatically gets called in the State machine. Allows you to delay flow if desired
    public abstract void Enter();
    // automatically gets called in the State machine. Allows you to delay flow if desired
    public abstract void Exit();
    // allows simulation of Update() method without a MonoBehaviour attached
    public abstract void Tick();
}