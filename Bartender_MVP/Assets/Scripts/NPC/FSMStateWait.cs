using UnityEngine;

public class FSMStateWait : FSMState
{
    public FSMStateWait(FSM fsm) : base(fsm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Wait state ENTER");
    }

    public override void Exit()
    {
        Debug.Log("Wait state EXIT");
    }

    public override void Update()
    {
        
    }
}
