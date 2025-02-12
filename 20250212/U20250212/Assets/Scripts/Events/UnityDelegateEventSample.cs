using System;
using UnityEngine;
using UnityEngine.UI;

// delegate�� �̿��ϸ�, �̺�Ʈ�� �� ���� © �� �ִ�.

class MeetEvent
{
    public delegate void MeetEventHandler(string message);
    public event MeetEventHandler meethandler;

    public void Meet()
    {
        meethandler("���� �͵� �ο��ε� ��𰡼� ���� �� ��....");
    }
}

public class UnityDelegateEventSample : MonoBehaviour
{
    public Text messageUI;
    MeetEvent meetEvent = new MeetEvent();

    void Start()
    {
        var meetEvent = new MeetEvent();
        meetEvent.meethandler += EventMessage;
    }

    private void EventMessage(string message)
    {
        // Debug.Log(message);
        messageUI.text = message;
    }

    public void OnMeetButtonEnter()
    {
        meetEvent.Meet();
    }
}
