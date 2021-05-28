using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public List<GameObject> targets;
    public static List<GameObject> current;
    public List<GameObject> checkObj;
    public Image formulaMake;
    public Image formula;
    public Text answer;
    void Awake()
    {
        current = new List<GameObject>();
}
    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag != null && targets.Contains(eventData.pointerDrag))
        {
            current.Add(eventData.pointerDrag);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;           
        }
    }
    public void isInCurrent(GameObject obj)
    {
        if (current.Contains(obj))
        {
            current.Remove(obj);
        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            formulaMake.gameObject.SetActive(false);
            formula.gameObject.SetActive(true);
            answer.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void Check()
    {
        bool ok = true;
        foreach(var obj in checkObj)
        {
            if (!current.Contains(obj))
                ok = false;
        }
        if (ok)
        {
            Debug.Log("OK");
            formulaMake.gameObject.SetActive(false);
            formula.gameObject.SetActive(true);
            answer.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }

}
