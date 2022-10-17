using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalBools 
{
    // Se debe activar cuando se entre en el rango del NPC/Objecto/Puerta//
    //public static bool _activeFeedback = false;

    //Si esta en el rango del jugador un NPC este se activara. Permitiendo que el jugador pueda interactuar con el npc//
    public static bool _canTalk = false;

    //Permitira saber el progreso del juego//
    public static bool _stage1 = true;

    public static bool _DevicePreIsKeyBoard = true;
}
