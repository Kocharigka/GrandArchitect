using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsSound : MonoBehaviour
{
	/* // Start is called before the first frame update
	 void Start()
	 {

	 }

	 // Update is called once per frame
	 void Update()
	 {

	 }*/

	public float volume = 0; //���������
	public AudioMixer audioMixer; //��������� ���������

	public void ChangeVolume(float val) //��������� �����
	{
		volume = val;
	}

	public void SaveSettings()
	{
		audioMixer.SetFloat("MasterVolume", volume); //��������� ������ ���������
	}



}
