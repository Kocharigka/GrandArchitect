using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public List<GameObject> targets;
    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null && targets.Contains(eventData.pointerDrag))
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
    }
}
