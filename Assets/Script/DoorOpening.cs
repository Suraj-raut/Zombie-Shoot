using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
  public float DistancefromDoor;
  public GameObject ActionKey;
  public GameObject ActionText;
  public GameObject Door;
  public GameObject PointerCrossOver;
	
    void Update()
    {
        DistancefromDoor = PlayerCasting.DistancefromTarget;
    }
	
	void OnMouseOver ()
	{
		if(DistancefromDoor <= 2)
		{
			ActionKey.SetActive(true);
			ActionText.SetActive(true);
			PointerCrossOver.SetActive(true);
		}
		
		if(Input.GetButtonDown("Action"))
		{
			if(DistancefromDoor <= 2)
			{
				
			this.GetComponent<BoxCollider>().enabled = false ;
			ActionKey.SetActive (false);
			ActionText.SetActive (false);
		    Door.GetComponent<Animation>().Play("DoorOpening");	
			
			}
		}
	}
	
	void OnMouseExit ()
	{
		ActionKey.SetActive (false);
		ActionText.SetActive (false);
		PointerCrossOver.SetActive(false);
	}
}
