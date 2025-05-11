using UnityEngine;

public class Player : MonoBehaviour
{
    public MyState mystate;
    private void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * 0.2f, Input.GetAxisRaw("Vertical") * 0.2f, 0);

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            mystate.SetState(new StateHorizontal());
            mystate.Operate();
        }
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            mystate.SetState(new StateVertical());
            mystate.Operate();
        }
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            mystate.SetState(new StateStop());
            mystate.Operate();
        }
    }
}
