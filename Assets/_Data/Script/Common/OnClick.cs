using UnityEngine;


public class OnClick : IOnClick
{
    bool IOnClick.OnClick()
    {
        return Input.GetMouseButtonDown(0) ||
          (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began);
    }


}
