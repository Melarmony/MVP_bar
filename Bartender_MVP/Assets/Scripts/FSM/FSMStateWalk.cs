using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.FSM
{
    public class FSMStateWalk : FSMState
    {
        public FSMStateWalk(global::FSM fsm) : base(fsm) { }

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
        }
    }
}