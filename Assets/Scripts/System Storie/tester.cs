using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{
    public Conversation convo;
   public void StartConvo()
    {
        DialogueManager.StartConversation(convo);
    }
}
