using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CharacterMenuList : MonoBehaviour
{
    private List<Character> menuCharacters = new();

    [SerializeField]
    private Transform characterSlotContainer;
    [SerializeField]
    private GameObject characterSlot;
    private float slotSize = 100f;



    private void Awake()
    {
        characterSlotContainer = transform.Find("characterSlotContainer");
    }

    private void Start()
    {
        menuCharacters = SquadManager.main.getSquadList();
        refreshCharacterList();
    }

    private void refreshCharacterList()
    {
        int x = 0;
        int y = 0;
        foreach (Character menuCharacter in menuCharacters)
        {
            GameObject slot = Instantiate(characterSlot, characterSlotContainer);
            slot.GetComponent<CharacterSlot>().setCharacter(menuCharacter);
            slot.gameObject.SetActive(true);

            RectTransform characterSlotTransform = slot.GetComponent<RectTransform>();
            characterSlotTransform.anchoredPosition = new Vector2 (x, y * slotSize);
            Image img = characterSlotTransform.Find("image").GetComponent<Image>();
            img.sprite = menuCharacter.getData().characterMenuSprite;
            y++;
        }
    }
}
