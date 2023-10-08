using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeploySystem : MonoBehaviour
{

    public static DeploySystem instance;
    private Character characterToDeploy;

    private void Awake()
    {
        instance = this;
    }
    public void selectCharacter(Character character)
    {
        this.characterToDeploy = character;
    }
    public void deselect()
    {
        this.characterToDeploy = null;
    }
}
