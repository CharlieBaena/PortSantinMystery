using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCManager : MonoBehaviour
{
    [SerializeField] NPCDetails _nPCDetails;
    [SerializeField] GameObject _dialoguePanel;
    [SerializeField] TextMeshProUGUI _displayText;
    [SerializeField] float _typingSpeed;

    public static int _IndexDialogue;
    string sentence;

    private void Start()
    {
        _dialoguePanel = GameObject.Find("dialoguePanel");
        
        
    }


  

    private void Update()
    {

        if (GlobalBools._nowIsTalking)
        {
            Speaker();

        }
    }


    private void Speaker()
    {

       

    }



    //Esto hara que el texto se escriba lentamente//
    IEnumerator letterOnetoOne()
    {
        _displayText.text = " ";

        foreach (char letter in sentence.ToCharArray())
        {
            _displayText.text += letter;

        }

        yield return new WaitForSeconds(_typingSpeed);
    }











    //Esto detectara si el jugador esta cerca del npc//
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //GlobalBools._activeFeedback = true;
            GlobalBools._canTalk = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GlobalBools._canTalk = false;
        }
    }

}
