using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickup : MonoBehaviour
{
    public GameObject Ammo;
	public GameObject AmmoDisplay;
	public static int AmmoCount = 3;
	public int internalAmmoCount; 
	public GameObject Gun;
	public static bool isGunActive = false;
	public AudioSource AmmoPickupFX;
	
	void Update()
	{
		
		internalAmmoCount = AmmoCount;
		
		if(isGunActive == true)
		{
		AmmoDisplay.GetComponent<Text>().text = "" + AmmoCount;
		}
	
	}
	void OnTriggerEnter()
	{
		Ammo.SetActive(false);
		AmmoDisplay.SetActive(true);
		AmmoCount += 10;
		AmmoPickupFX.Play();
		
	}
	


}
