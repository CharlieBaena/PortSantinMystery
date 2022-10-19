using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvo : MonoBehaviour
{
   public Conversation convo;

    private void Start()
    {
        EventManager._Talk.AddListener(CheckConve);
    }

    public void StartConve()
    {
        DialogueManager.StartConversation(convo);
    }

    public void CheckConve()
    {
        if(GlobalBools._driverTalking)
        {
            if(GlobalBools._stage1)
            {

            }
        }

        if (GlobalBools._reviewerTalking)
        {
            if (GlobalBools._stage1)
            {

            }
        }

        if (GlobalBools._lunaTalking)
        {
            if (GlobalBools._stage1)
            {

            }
        }

        if (GlobalBools._centurionTalking)
        {
            if (GlobalBools._stage1)
            {

            }
        }

        if (GlobalBools._jorgeTalking)
        {
            if (GlobalBools._stage1)
            {

            }
        }


    }
}
