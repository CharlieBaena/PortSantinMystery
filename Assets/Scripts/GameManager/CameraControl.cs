using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera _camCurrent;



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(CameraSwitcher.ActiveCamera != _camCurrent)
            {
                CameraSwitcher.SwitchCamera(_camCurrent);
            }
        }
    }
}
