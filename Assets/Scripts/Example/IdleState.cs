using System.Reflection;
using UnityEngine;

public class IdleState : State
{
    public override void OnEnter()
    {
        Debug.Log($"{GetType()}.{MethodBase.GetCurrentMethod().Name}");
    }

    public override void OnUpdate()
    {
        Debug.Log($"{GetType()}.{MethodBase.GetCurrentMethod().Name}");
        if (Time.time > 1)
        {
            GetComponent<FiniteStateMachine>().State = GetComponent<AttackState>();
        }
    }

    public override void OnExit()
    {
        Debug.Log($"{GetType()}.{MethodBase.GetCurrentMethod().Name}");
    }
}
