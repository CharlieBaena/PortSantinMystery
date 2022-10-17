using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvo : MonoBehaviour
{
   public Conversation convo;

    private void Start()
    {
        //EventManager._Talk.AddListener(StartConve);
    }

    public void StartConve()
    {
        DialogueManager.StartConversation(convo);
    }
}
