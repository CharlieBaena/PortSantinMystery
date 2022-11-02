using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite;

    private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Coroutine typing;

    UserActions _controls;
    private InputAction NextLine;

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

        _controls = new UserActions();
    }

    private void OnEnabled()
    {
        print("E");
        NextLine = _controls.UI.NextLine;
        NextLine.Enable();
        NextLine.performed += ReadNext;

    }

    private void OnDisable()
    {
        print("D");
        NextLine.Disable();
    }

    public static void StartConversation(Conversation convo)
    {
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext(new InputAction.CallbackContext());
    }

    public void ReadNext(InputAction.CallbackContext context)
    {
        if(currentIndex> currentConvo.GetLength())
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
       
        speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
        currentIndex++;


        if(currentIndex >= currentConvo.GetLength())
        {
            this.gameObject.SetActive(false);
            navButtonText.text = "x";
        }
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
            yield return new WaitForSeconds(0.02f);

            if(index == text.Length)
            {
                complete = true;
            }
        }

        typing = null;
    }
}
