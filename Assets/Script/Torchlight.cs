using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torchlight : MonoBehaviour
{
	public int Lightmode = 0;
	public GameObject Flashlight;
   
    // Update is called once per frame
    void Update()
    {
		if(Lightmode == 0)
		{
			StartCoroutine (LightIntensity());
		}
		
	
		
    }
	
	IEnumerator LightIntensity()
	{
		Lightmode = Random.Range(0,4);
		
		
		if(Lightmode == 1)
		{
			Flashlight.GetComponent<Animation>().Play("Light1");
		}
		
		if(Lightmode == 2)
		{
			Flashlight.GetComponent<Animation>().Play("Light2");
		}
		if(Lightmode == 3)
		{
			Flashlight.GetComponent<Animation>().Play("Light3");
		}
		
		yield return new WaitForSeconds(0.5f);
		Lightmode = 0;
		
	}
}
