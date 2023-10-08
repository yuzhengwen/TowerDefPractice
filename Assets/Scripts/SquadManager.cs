using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadManager : MonoBehaviour
{
    public static SquadManager main { get; private set; }

    private static List<Character> squad;

    private void Awake()
    {
        main = this;
        squad = new List<Character>();
        addToSquad(Character.CharacterType.Yuzie);
        addToSquad(Character.CharacterType.Chloe);
    }
    private void Start()
    {
    }

    public void addToSquad(Character.CharacterType type)
    {
        squad.Add(new Character() { characterType=type});
    }

    public List<Character> getSquadList()
    {
        return squad;
    }
}
