using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{
   public static Conversation convo;

    private void Start()
    {
        EventManager._Talk.AddListener(StartConvo);
    }

    public void StartConvo()
    {
        DialogueManager.StartConversation(convo);
    }
}
