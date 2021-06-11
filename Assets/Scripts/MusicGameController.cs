using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicGameController : MonoBehaviour
{
	//public GameObject gameMusic;

	[SerializeField] Toggle audioToggle;
	private void Start()
	{
		if (AudioListener.volume == 0)
		{
			audioToggle.isOn = false;
		}
	}



	/*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
