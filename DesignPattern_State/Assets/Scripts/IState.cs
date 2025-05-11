using UnityEngine;
using UnityEngine.UI;

public interface IState
{
    void Execute(GameObject player, Text text);
}

public class StateHorizontal : IState
{
    public void Execute(GameObject player, Text text)
    {
        text.text = "���η� �̵���..";
    }
}

public class StateVertical : IState
{
    public void Execute(GameObject player, Text text)
    {
        text.text = "���η� �̵���...";
    }
}

public class StateStop : IState
{
    public void Execute(GameObject player, Text text)
    {
        text.text = "�����߽��ϴ�.";
    }
}