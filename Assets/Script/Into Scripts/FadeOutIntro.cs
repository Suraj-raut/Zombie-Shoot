using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutIntro : MonoBehaviour
{
	
	public GameObject Place;
	public GameObject Date;
	public GameObject Divider;
	public GameObject IntroText;
	public AudioSource Line1;
	public AudioSource Line2;
	public AudioSource Line3;
	public AudioSource Line4;
	public AudioSource Line5;
	public AudioSource FootSteps;
	public AudioSource Breathing;
	
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeInto());
		
    }
	
    IEnumerator FadeInto()
    {
	  yield return new WaitForSeconds(2);
		Place.GetComponent<Animation>().Play("IntroFadeOut");
		yield return new WaitForSeconds(1.5f);
		Divider.GetComponent<Animation>().Play("IntroFadeOut");
		yield return new WaitForSeconds(1);
		Date.GetComponent<Animation>().Play("IntroFadeOut");
		yield return new WaitForSeconds(3);
		Place.GetComponent<Animation>().Play("FadeOutOpening");
		yield return new WaitForSeconds(1);
		Date.GetComponent<Animation>().Play("FadeOutOpening");
		Divider.GetComponent<Animation>().Play("FadeOutOpening");
		StartCoroutine(IntroLines());
		
    }
	
	IEnumerator IntroLines()
	{
		yield return new WaitForSeconds(10);
		IntroText.GetComponent<Text>().text = "The night of 29th October 2008 changed me forever..!!!";
		Line1.Play();
		yield return new WaitForSeconds(4);
		IntroText.GetComponent<Text>().text = " ";
		
		yield return new WaitForSeconds(10);
		IntroText.GetComponent<Text>().text = "I headed out to investigate the hauting sounds from the woods";
		Line2.Play();
		yield return new WaitForSeconds(5);
		IntroText.GetComponent<Text>().text = " ";
		
		yield return new WaitForSeconds(10);
		IntroText.GetComponent<Text>().text = "I stambled upon a cabin with a clearing on a distance";
		Line3.Play();
		yield return new WaitForSeconds(5);
		IntroText.GetComponent<Text>().text = " ";
		
		yield return new WaitForSeconds(10);
		IntroText.GetComponent<Text>().text = "I can here those sounds again coming from there";
		Line4.Play();
		yield return new WaitForSeconds(4);
		IntroText.GetComponent<Text>().text = " ";
		
		yield return new WaitForSeconds(10);
		IntroText.GetComponent<Text>().text = "Little did i know will, this is only the Begaining..!!";
		Line5.Play();
		yield return new WaitForSeconds(5);
		IntroText.GetComponent<Text>().text = " ";
		
		yield return new WaitForSeconds(3);
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		yield return new WaitForSeconds(2);
		Breathing.Play();
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		yield return new WaitForSeconds(1);
		FootSteps.Play();
		
		
	}
	
}
