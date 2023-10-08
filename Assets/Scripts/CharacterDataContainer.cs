using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataContainer : MonoBehaviour
{
    public static CharacterDataContainer instance;

    [SerializeField]
    private List<CharacterData> characterDataList = new();

    private void Awake()
    {
        instance = this;
    }
    public List<CharacterData> getList()
    {
        return characterDataList;
    }

    public CharacterData getIndex(int index)
    {
        return characterDataList[index];
    }
}
