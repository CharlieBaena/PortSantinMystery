using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{

    //public static UnityEvent _cameraFarChurch = new UnityEvent();
    //public static UnityEvent _cameraZoomChurch = new UnityEvent();
    //public static UnityEvent _cameraFarHotel = new UnityEvent();
    //public static UnityEvent _cameraZoomHotel = new UnityEvent();

    public static UnityEvent _Talk = new UnityEvent();

    public static UnityEvent _OpenInventory = new UnityEvent();
    public static UnityEvent _CloseInventory = new UnityEvent();

    public static UnityEvent _DoorDetect = new UnityEvent();

    public static UnityEvent _StartFeedback = new UnityEvent();
    public static UnityEvent _StopFeedback = new UnityEvent();
}
