using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite1;
    public Image speakerSprite2;

    [SerializeField]private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Coroutine typing;

    [SerializeField] GameObject _dialogueBox;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {

        _dialogueBox = GameObject.Find("DialogueBox");

        
        
    }

    public static void StartConversation(Conversation convo)
    {
       
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext();


    }


    public void ReadNext()
    {
        
        if(currentIndex > currentConvo.GetLength())
        {

            return;

        }

        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

        if(typing == null)
        {
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }
        else
        {
            instance.StopCoroutine(typing);
            typing = null;
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }
       
        speakerSprite1.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains1;
        speakerSprite2.sprite = currentConvo.GetLineByIndex(currentIndex)._SpritePortrains2;
        
       
        currentIndex++;


        if(currentIndex == currentConvo.GetLength())
        {
            GlobalBools._isEndLineDialogue = true;

            //navButtonText.text = "x";
        }
    }

    public void EndDialogue()
    {
        _dialogueBox.SetActive(false);

        GlobalBools._isWaitingForInteractue = false;

        currentIndex = 0;
    }

    private IEnumerator TypeText(string text)
    {

        dialogue.text = "";
        bool complete = false;
        int index = 0;

        while(!complete)
        {
            dialogue.text += text[index];
            index++;
            yield return new WaitForSeconds(0.06f);

            if(index == text.Length)
            {
                complete = true;
            }
        }

        typing = null;
    }
}
