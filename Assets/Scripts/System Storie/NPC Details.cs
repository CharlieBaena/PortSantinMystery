using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCDetails 
{

    public string _name;
    public Sprite[] _faces;

    [TextArea(3, 10)]
    public string[] _sentencesList;

}
