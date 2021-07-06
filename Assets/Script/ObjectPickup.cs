using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPickup : MonoBehaviour
{
  public float DistancefromWeapon;
  public GameObject ActionKey;
  public GameObject ActionText;
  public GameObject RealGun;
  public GameObject FakeGun;	
  public GameObject PointerCrossOver;
  public GameObject BulletsDisplay;
  public static bool isPickup;
  public bool internalPickup;
  public AudioSource PickupFX;	
  	
    
	void Update()
    {
		internalPickup = isPickup;
        DistancefromWeapon = PlayerCasting.DistancefromTarget;
		if(isPickup == true)
		{
			BulletsDisplay.SetActive(true);
		}
		
    }
	
	void OnMouseOver ()
	{
		if(DistancefromWeapon <= 2)
		{
			ActionKey.SetActive (true);
			ActionText.SetActive (true);
			ActionKey.GetComponent<Text>().text = "[ Q ]";
			ActionText.GetComponent<Text>().text = "To pickup the weapon";
			PointerCrossOver.SetActive(true);
		}
		
		if(Input.GetButtonDown("Pickup"))
		{
			if(DistancefromWeapon <= 2)
			{
				
			ActionKey.SetActive (false);
			ActionText.SetActive (false);
		    RealGun.SetActive (true);
			AmmoPickup.isGunActive = true;
		    FakeGun.SetActive(false);
			PickupFX.Play();		
				
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
