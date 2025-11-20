using UnityEngine;
using System.Collections;

public class FSMStateWait : FSMState
{
    protected readonly int npcId;
    protected readonly DrinkManager drinkManager;

    public FSMStateWait(FSM fsm, int npcId) : base(fsm)
    {
        this.npcId = npcId;
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
        if (drinkManager.IfHasDrink(npcId))
        {
            Fsm.SetState<FSMStateDrink>();
        }
    }
}
