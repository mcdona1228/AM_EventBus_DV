using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            EventBus.TriggerEvent("Shoot");
        }
        if (Input.GetKeyDown("l"))
        {
            EventBus.TriggerEvent("Launch");
        }
        if (Input.GetKeyDown("h"))
        {
            EventBus.TriggerEvent("Hug");
        }
        if (Input.GetKeyDown("p"))
        {
            EventBus.TriggerEvent("Punch");
        }
        if (Input.GetKeyDown("t"))
        {
            EventBus.TriggerEvent("Talk");
        }
    }
}
