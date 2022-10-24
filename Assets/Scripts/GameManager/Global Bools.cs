using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalBools 
{
    // Se debe activar cuando se entre en el rango del NPC/Objecto/Puerta//
    //public static bool _activeFeedback = false;

    //Si esta en el rango del jugador un NPC este se activara. Permitiendo que el jugador pueda interactuar con el npc//
    public static bool _canTalk = false;

    //NPCS
    public static bool _driverTalking = false;
    public static bool _reviewerTalking = false;
    public static bool _lunaTalking = false;
    public static bool _centurionTalking = false;
    public static bool _jorgeTalking = false;

    //Permitira saber el progreso del juego//
    public static bool _stage1 = true;

    public static bool _canOpenDoor = false;
    public static bool _OpenInventory = false;

    public static bool _run = false;

    //public static bool _DevicePreIsKeyBoard = true;
}
