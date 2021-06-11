using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MuteToggle : MonoBehaviour
{
	Toggle myToggle;
	

	// Start is called before the first frame update
    void Start()
    {
		myToggle = GetComponent<Toggle>();
		if (AudioListener.volume == 0)
		{
			myToggle.isOn = false;
		}
		PlayerPrefs.SetInt("tipsOn", 0);
    }

	public void ToggleAudioOnValueChange(bool audioIn)
	{
		if (audioIn)
		{
			AudioListener.volume = 1;
		}
		else
		{
			AudioListener.volume = 0;
		}
	}
	public void ToggleTips()
    {
        if (PlayerPrefs.HasKey("tipsOn"))
        {
			PlayerPrefs.DeleteKey("tipsOn");
			PlayerPrefs.Save();
        }
        else
        {
			PlayerPrefs.SetInt("tipsOn", 0);
			PlayerPrefs.Save();
		}
    }
}
