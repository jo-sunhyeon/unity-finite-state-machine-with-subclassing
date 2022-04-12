using UnityEngine;

[RequireComponent(typeof(NullState))]
public class FiniteStateMachine : MonoBehaviour
{
    public State State
    {
        get
        {
            return state;
        }

        set
        {
            state.OnExit();
            state = value;
            state.OnEnter();
        }
    }

    private void Awake()
    {
        state = gameObject.GetComponent<NullState>();
    }

    private void Update()
    {
        state.OnUpdate();
    }

    private State state;
}
