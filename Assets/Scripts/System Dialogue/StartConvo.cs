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
        //if(GlobalBools._isdriverTalking)
        //{
        //    if(GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._isreviewerTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._islunaTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}

        //if (GlobalBools._iscenturionTalking)
        //{
        //    if (GlobalBools._stage1)
        //    {

        //    }
        //}
        if (GlobalBools._canJorgeTalkMore)
        {
            if (GlobalBools._isjorgeTalking)
            {
                if (GlobalBools._stage1)
                {

                    convo = Resources.Load<Conversation>("Jorge/First_Conversation");
                    _dialogueBox.SetActive(true);
                    GlobalBools._canMoreTalk = true;
                    StartConve();
                }

                if (GlobalBools._canMoreTalk)
                {
                    //convo = Resources.Load<Conversation>("Jorge/
                    _dialogueBox.SetActive(true);
                    GlobalBools._canMoreTalk = true;
                    StartConve();
                    GlobalBools._canJorgeTalkMore = false;
                }
            }

        }
    }
}
