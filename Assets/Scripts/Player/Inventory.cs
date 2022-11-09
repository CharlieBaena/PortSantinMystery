using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class Inventory : MonoBehaviour
{
    
    [SerializeField] GameObject _Panel, Archive1, Archive2, Archive3, Archive4, KeyBottom, GamePadBottom, _reviewer, _driver, _jorge, _luna, _centurion, _prayer;

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
        _reviewer.SetActive(false);
        _driver.SetActive(false);
        _jorge.SetActive(false);
        _luna.SetActive(false);
        _prayer.SetActive(false);
        _centurion.SetActive(false);
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


    public void Reviewer()
    {
        _reviewer.SetActive(true);
        _driver.SetActive(false);
        _jorge.SetActive(false);
        _luna.SetActive(false);
        _prayer.SetActive(false);
        _centurion.SetActive(false);
    }
    public void Driver()
    {
        _reviewer.SetActive(false);
        _driver.SetActive(true);
        _jorge.SetActive(false);
        _luna.SetActive(false);
        _prayer.SetActive(false);
        _centurion.SetActive(false);
    }
    public void Jorge()
    {

        _reviewer.SetActive(false);
        _driver.SetActive(false);
        _jorge.SetActive(true);
        _luna.SetActive(false);
        _prayer.SetActive(false);
        _centurion.SetActive(false);
    }
    public void Luna()
    {
        _reviewer.SetActive(false);
        _driver.SetActive(false);
        _jorge.SetActive(false);
        _luna.SetActive(true); 
        _prayer.SetActive(false);
        _centurion.SetActive(false);
    }

    public void Prayer()
    {
        _reviewer.SetActive(false);
        _driver.SetActive(false);
        _jorge.SetActive(false);
        _luna.SetActive(false);
        _prayer.SetActive(true);
        _centurion.SetActive(false);
    }

    public void Centurion()
    {
        _reviewer.SetActive(false);
        _driver.SetActive(false);
        _jorge.SetActive(false);
        _luna.SetActive(false);
        _prayer.SetActive(false);
        _centurion.SetActive(true);
    }

}
