using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterSlot : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler
{

    private Character character = new();

    [SerializeField]
    private Canvas canvas;
    private RectTransform rectTransform;
    private Image bg;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        bg = transform.Find("background").GetComponent<Image>();
    }
    public void mouseEnter()
    {
        bg.CrossFadeAlpha(0.2f, 0.5f, false);
    }
    public void mouseExit()
    {
        bg.CrossFadeAlpha(0.8f, 0.5f, false);
        DeploySystem.instance.deselect();
    }

    public void setCharacter(Character character)
    {
        this.character = character;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        bg.CrossFadeAlpha(0f, 0.5f, false);
    }

}
