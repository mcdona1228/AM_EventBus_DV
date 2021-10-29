using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    private bool m_IsQuitting;
    void OnEnable()
    {
        EventBus.StartListening("Punch", Punch);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Punch", Punch);
        }
    }
    void Punch()
    {
        Debug.Log("Received a punch event : I'm gonna punch you in the FACE!");
    }
}
