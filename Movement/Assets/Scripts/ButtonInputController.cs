using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInputController : MonoBehaviour
{
    public UnityEvent buttonDownEvent = new UnityEvent();
    public UnityEvent buttonUpEvent = new UnityEvent();

    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            buttonDownEvent.Invoke();
        }
        else if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            buttonUpEvent.Invoke();
        }
    }
}