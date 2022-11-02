using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvo : MonoBehaviour
{
   public Conversation convo;

    [SerializeField] GameObject _dialogueBox;

    private void Start()
    {
        _dialogueBox = GameObject.Find("DialogueBox");


        EventManager._Talk.AddListener(CheckConve);

        _dialogueBox.SetActive(false);

    }

    public void StartConve()
    {
        GlobalBools._nextLineActive = true;
        DialogueManager.StartConversation(convo);
      
    }

    public void CheckConve()
    {
        //if(GlobalBools._driverTalking)
        //{
        //    if(GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._reviewerTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._lunaTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._centurionTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        if (GlobalBools._jorgeTalking)
        {
            if (GlobalBools._stage1)
            {
                convo = Resources.Load<Conversation>("Jorge/First_Conversation");
                _dialogueBox.SetActive(true);
                StartConve();
            }
        }


    }
}
