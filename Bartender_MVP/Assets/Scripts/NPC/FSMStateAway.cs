using UnityEngine;

public class FSMStateAway : FSMState
{
    public FSMStateAway(FSM fsm) : base(fsm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Away state ENTER");
    }

    public override void Exit()
    {
        Debug.Log("Away state EXIT");
    }

    public override void Update()
    {

    }
}
