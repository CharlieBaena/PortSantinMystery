using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToInteract : MonoBehaviour
{

    DialogueManager dialogueManager;
    [SerializeField] UserActions _controls;
    private InputAction Interact;
    private InputAction Inventory;
    private InputAction NextLine;

   

    private void Awake()
    {
        _controls = new UserActions();
    }

    private void Update()
    {
        if(GlobalBools._nextLineActive)
        {

            dialogueManager = FindObjectOfType<DialogueManager>();

        }
    }

    public void OnEnable()
    {

        Interact = _controls.Player.Interactue;
        Interact.Enable();
        Interact.performed += StartInteract;
       
        Inventory = _controls.Player.Inventory;
        Inventory.Enable();
        Inventory.performed += OpenInventory;

        NextLine = _controls.UI.NextLine;

        NextLine.Enable();

        NextLine.performed += NextLineText;
    }

    public void OnDisable()
    {
        Interact.Disable();
        Inventory.Disable();
        NextLine.Disable();
    }


    private void OpenInventory(InputAction.CallbackContext context)
    {
        
        if (!GlobalBools._canOpenInventory)
        {

            
            GlobalBools._canOpenInventory = true;
            EventManager._OpenInventory.Invoke();

        }
        else
        {

            GlobalBools._canOpenInventory = false;
            EventManager._CloseInventory.Invoke();


        }
    }

    private void StartInteract(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isWaitingForInteractue)
        {
            if (GlobalBools._canTalk)
            {
                EventManager._Talk.Invoke();
                GlobalBools._isWaitingForInteractue = true;

            }
        }

        if(!GlobalBools._isWaitingForInteractue)
        {
            if (GlobalBools._canOpenDoor)
            {
                EventManager._changeScene.Invoke();
                GlobalBools._isWaitingForInteractue = true;
            }
        }
        
    }

    public void NextLineText(InputAction.CallbackContext context)
    {
        if (!GlobalBools._isEndLineDialogue)
        {
            dialogueManager.ReadNext();
            return;
        }
        else
        {
            dialogueManager.EndDialogue();
            return;
        }
    }
}
