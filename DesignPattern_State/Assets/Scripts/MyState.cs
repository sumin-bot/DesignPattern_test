using UnityEngine;
using UnityEngine.UI;

public class MyState : MonoBehaviour
{
    public GameObject player;
    public Text text;

    public IState curState;

    private void Start()
    {
        curState = new StateStop();
    }

    public void Operate()
    {
        curState.Execute(player, text);
    }

    public void SetState(IState newState)
    {
        curState = newState;
    }
}
