using UnityEngine;

public class FSMStateDrink : FSMState
{
    public FSMStateDrink(FSM fsm) : base(fsm)
    {
    }

    public override void Enter()
    {
        Debug.Log("Drink state ENTER");
    }

    public override void Exit()
    {
        Debug.Log("Drink state EXIT");
    }

    public override void Update()
    {

    }
}
