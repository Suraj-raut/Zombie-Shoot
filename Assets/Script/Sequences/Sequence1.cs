using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Sequence1 : MonoBehaviour
{
	
	public GameObject OpeningScreen;
	public GameObject SequenceText;
	public GameObject Player;
	
    // Start is called before the first frame update
    void Start()
    {
		Player.GetComponent<DarkTreeFPS.FPSController>().enabled = false;
        StartCoroutine(OpeningSequence());
    }

   
	
	IEnumerator OpeningSequence ()
	{
		yield return new WaitForSeconds(1.5f);
		OpeningScreen.SetActive(false);
		SequenceText.GetComponent<Text>().text = "I need to get out of here..!!!";
		yield return new WaitForSeconds(2);
		SequenceText.GetComponent<Text>().text = " ";
		Player.GetComponent<DarkTreeFPS.FPSController>().enabled = true;
		
	}
}
