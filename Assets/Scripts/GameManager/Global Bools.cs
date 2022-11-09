using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalBools 
{
    // Se debe activar cuando se entre en el rango del NPC/Objecto/Puerta//
    //public static bool _activeFeedback = false;

    //Si esta en el rango del jugador un NPC este se activara. Permitiendo que el jugador pueda interactuar con el npc//
    public static bool _canTalk = false;
    public static bool _nextLineActive = false;

    //NPCS

    public static bool _isknowDriver = false;
    public static bool _isknowReviewer = false;
    public static bool _isknowLuna = false;
    public static bool _isknowCenturion = false;
    public static bool _isknowJorge = false;
    public static bool _isknowPrayer = false;

    public static bool _isdriverTalking = false;
    public static bool _isreviewerTalking = false;
    public static bool _islunaTalking = false;
    public static bool _iscenturionTalking = false;
    public static bool _isjorgeTalking = false;
    public static bool _isprayerTalking = false;

    public static bool _canJorgeTalkMore = true;


    public static bool _canMoreTalk = false;


    public static bool _isWaitingForInteractue = false;
    //Permitira saber el progreso del juego//
    public static bool _stage1 = true;

    public static bool _canOpenDoor = false;
    public static bool _canOpenInventory = false;
    public static bool _isEndLineDialogue = false;

    public static bool _isRunning = false;

    //public static bool _DevicePreIsKeyBoard = true;
}
