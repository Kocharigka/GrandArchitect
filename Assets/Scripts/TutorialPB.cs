using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPB : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider newSlider;
    public Slider oldSlider;
    private float speed = 0.5f;
    public GameObject gameManager;  
    
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (newSlider.value < oldSlider.value)
            newSlider.value += speed * Time.deltaTime;
    }
    public void Increment()
    {
        var a = gameManager.GetComponent<TutorialManager>().progress;
        oldSlider.value = a;       
    }
}
