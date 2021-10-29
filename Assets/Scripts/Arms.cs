using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{
    private bool m_IsQuitting;
    void OnEnable()
    {
        EventBus.StartListening("Hug", Hug);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Hug", Hug);
        }
    }
    void Hug()
    {
        Debug.Log("Received a hug event : HUUUUUUG!");
    }
}
