using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Sequence2 : MonoBehaviour
{
	
	public GameObject SequenceText;
	public GameObject Player;
	
    // Start is called before the first frame update
    void Start()
    {
		Player.GetComponent<DarkTreeFPS.FPSController>().enabled = false;
	}
	
	
	void OnTriggerEnter()
	{
		   StartCoroutine(OpeningSequence());
    }

   
	
	IEnumerator OpeningSequence ()
	{
		SequenceText.GetComponent<Text>().text = "The Door is Locked..!!!";
		yield return new WaitForSeconds(1.5f);
		SequenceText.GetComponent<Text>().text = " ";
		Player.GetComponent<DarkTreeFPS.FPSController>().enabled = true;
		
	}
	
}
