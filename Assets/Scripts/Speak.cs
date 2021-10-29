using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speak : MonoBehaviour
{
    private bool m_IsQuitting;
    void OnEnable()
    {
        EventBus.StartListening("Talk", Talk);
    }
    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }
    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("Talk", Talk);
        }
    }
    void Talk()
    {
        Debug.Log("Received a talk event : Time for a conversation!");
    }
}
