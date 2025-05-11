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
        text.text = "가로로 이동중..";
    }
}

public class StateVertical : IState
{
    public void Execute(GameObject player, Text text)
    {
        text.text = "세로로 이동중...";
    }
}

public class StateStop : IState
{
    public void Execute(GameObject player, Text text)
    {
        text.text = "정지했습니다.";
    }
}