using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CharacterData", menuName = "Character Data")]
public class CharacterData : ScriptableObject
{
    public int characterID;
    public string characterName;
    public GameObject characterPrefab;
    public GameObject projectilePrefab;

    public Sprite characterMenuSprite;
}
