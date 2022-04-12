using UnityEngine;

[RequireComponent(typeof(FiniteStateMachine))]
[RequireComponent(typeof(IdleState))]
[RequireComponent(typeof(AttackState))]
public class Example : MonoBehaviour
{
    private void Start()
    {
        GetComponent<FiniteStateMachine>().State = GetComponent<IdleState>();
    }
}
