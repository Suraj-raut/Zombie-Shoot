using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowingPlayer : MonoBehaviour
{
	public GameObject Player;
	public AudioSource FootStepsSound;
	public AudioSource BreathingFX;
	public GameObject SequenceText;
	public GameObject Trigger2;
	

	void OnTriggerEnter()
	{
		
		StartCoroutine(FollowingSequence());
	}
	
	IEnumerator FollowingSequence()
	{
		
		FootStepsSound.Play();
		yield return new WaitForSeconds(1);
		SequenceText.GetComponent<Text>().text = "Someone is Following me..!!!";
		yield return new WaitForSeconds(1);
		SequenceText.GetComponent<Text>().text = " ";
		BreathingFX.Play();
		yield return new WaitForSeconds(10);
		Trigger2.SetActive(false);
		
		
	}
}
