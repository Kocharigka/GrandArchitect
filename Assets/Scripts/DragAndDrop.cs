using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public Canvas canvas;
    private CanvasGroup canvasGroup;
    public GameObject slot;
    private SlotScript slotScript;
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        slotScript = slot.GetComponent<SlotScript>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {    
         
       canvasGroup.blocksRaycasts = false;
       canvasGroup.alpha = .6f;
       slotScript.isInCurrent(gameObject);      

        
    }

    public void OnDrag(PointerEventData eventData)
    {    
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;       
    }    

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
    }
}
