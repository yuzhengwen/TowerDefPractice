using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public enum CharacterType
    {
        Yuzie = 0,
        Chloe = 1
    }

    public CharacterType characterType;

    public CharacterData getData()
    {
        return CharacterDataContainer.instance.getIndex((int)characterType);
    }
}
