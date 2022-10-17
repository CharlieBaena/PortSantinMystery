using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectNPC : MonoBehaviour
{
    private Collider _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>();
    }

    private void OnTriggerStay(Collider other)
    {
        _player = other;

        if(other.gameObject.CompareTag("NPC1"))
        {

            GlobalBools._canTalk = true;

            //referenciar el progreso

            if(GlobalBools._stage1)
            {
                //referenciar busqueda de determinado scriptableObject
            }

        }
       

    }
}
