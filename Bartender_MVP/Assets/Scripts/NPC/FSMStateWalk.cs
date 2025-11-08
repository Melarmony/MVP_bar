using UnityEditor;
using UnityEngine;

public class FSMStateWalk : FSMState
{
    protected readonly Transform npcTransform;
    protected readonly Transform npcDrinkPoint;
    protected readonly float movementSpeed;


    public FSMStateWalk(FSM fsm, Transform transform, Transform stopPointTransform, float speed) : base(fsm) 
    {
        npcTransform = transform;
        movementSpeed = speed;  
        npcDrinkPoint = stopPointTransform;
    }

    public override void Enter()
    {
        Debug.Log("Walk state ENTER");
    }

    public override void Exit() 
    {
        Debug.Log("Walk state EXIT");
    }

    public override void Update() 
    {
        Debug.Log("Walk state UPDATE");
        MoveToBar();

        if (npcTransform.position.x == npcDrinkPoint.position.x)
        {
            Fsm.SetState<FSMStateWait>();
        }
    }

    private void MoveToBar()
    {
        npcTransform.position = Vector3.MoveTowards(npcTransform.position, npcDrinkPoint.position, movementSpeed * Time.deltaTime);
    }
}