using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class Inventory : MonoBehaviour
{
    
    [SerializeField] GameObject _Panel, Archive1, Archive2, Archive3, Archive4, KeyBottom, GamePadBottom, Npc1, Npc2, Npc3, Npc4;

    private void Start()
    {
        EventManager._OpenInventory.AddListener(OpenWindow);
        EventManager._CloseInventory.AddListener(CloseWindow);
        _Panel.SetActive(false);
    }
    
    private void OpenWindow()
    {
        _Panel.SetActive(true);
        Archive1.SetActive(true);
        Npc1.SetActive(false);
        Npc2.SetActive(false);
        Npc3.SetActive(false);
        Npc4.SetActive(false);
    }

    private void CloseWindow()
    {
        _Panel.SetActive(false);
    }


    public void ChangeArchive1()
    {

        Archive1.SetActive(true);
        Archive2.SetActive(false);
        Archive3.SetActive(false);
        Archive4.SetActive(false);
    }

    public void ChangeArchive2()
    {

        Archive1.SetActive(false);
        Archive2.SetActive(true);
        Archive3.SetActive(false);
        Archive4.SetActive(false);

    }

    public void ChangeArchive3()
    {

        Archive1.SetActive(false);
        Archive2.SetActive(false);
        Archive3.SetActive(true);
        Archive4.SetActive(false);

    }

    public void ChangeArchive4()
    {

        Archive1.SetActive(false);
        Archive2.SetActive(false);
        Archive3.SetActive(false);
        Archive4.SetActive(true);
        KeyBottom.SetActive(true);

    }



    public void ChangeImageControllersKey()
    {

        KeyBottom.SetActive(true);
        GamePadBottom.SetActive(false);

    }

    public void ChangeImageControllersGamePad()
    {
        KeyBottom.SetActive(false);
        GamePadBottom.SetActive(true);

    }


    public void NPC1()
    {
        Npc1.SetActive(true);
        Npc2.SetActive(false);
        Npc3.SetActive(false);
        Npc4.SetActive(false);
    }
    public void NPC2()
    {
        Npc1.SetActive(false);
        Npc2.SetActive(true);
        Npc3.SetActive(false);
        Npc4.SetActive(false);
    }
    public void NPC3()
    {

        Npc1.SetActive(false);
        Npc2.SetActive(false);
        Npc3.SetActive(true);
        Npc4.SetActive(false);
    }
    public void NPC4()
    {
        Npc1.SetActive(false);
        Npc2.SetActive(false);
        Npc3.SetActive(false);
        Npc4.SetActive(true);
    }

}
