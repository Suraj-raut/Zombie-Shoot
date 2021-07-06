using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{

	public AudioSource ButtonMusic;
	public GameObject LoadingScreen;
	
		public void PlayButton()
	{
		StartCoroutine(ButtonHit());
	}
	
	IEnumerator ButtonHit()
	{
	ButtonMusic.Play();
	yield return new WaitForSeconds(4);	
	LoadingScreen.SetActive(true);	
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	
}
