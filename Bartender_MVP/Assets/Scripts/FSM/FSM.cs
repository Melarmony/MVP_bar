using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;

public class FSM
{
    private Dictionary<Type, FSMState> states = new Dictionary<Type, FSMState>();

    private FSMState currentState { get; set; }

    public void AddState(FSMState state)
    {
        states.Add(state.GetType(), state);
    }

    public void SetState<T>() where T : FSMState
    {
        var type = typeof(T);  

        if (currentState != null && currentState.GetType() == type) { return; }

        if (states.TryGetValue(type, out var newState))
        {
            currentState?.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}
