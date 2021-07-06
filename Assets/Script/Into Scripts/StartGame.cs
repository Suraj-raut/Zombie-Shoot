using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public GameObject player;
   public AudioSource HitSound;
   public AudioSource HitPain;
   public GameObject LoadingScreen; 	

    // Update is called once per frame
 
	
	void Start()
	{
		LoadingScreen.SetActive(false);
	}
		
	
	
	void OnTriggerEnter()
		
	{
		StartCoroutine(EnterTheGame());
		
	}
	
	IEnumerator EnterTheGame()
	{
		yield return new WaitForSeconds(2);
		HitSound.Play();
		HitPain.Play();
		LoadingScreen.SetActive(true);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
		
	}
	 

}
