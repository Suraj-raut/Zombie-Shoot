using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
	public GameObject Pistol;
	public AudioSource GunShot;
	public bool IsFiring = false;
	public float distanceFromTarget;
	public int DamageAmount = 5;
	
    void Update()
    {

		ObjectPickup.isPickup = true;
		
        if(Input.GetButtonDown("Fire1") && AmmoPickup.AmmoCount >= 1)
				{
				  if(IsFiring == false)
				  {
					  AmmoPickup.AmmoCount -= 1;
					  StartCoroutine(FirePistol());
				  }
				}
    }
	
	IEnumerator FirePistol()
	{
		RaycastHit Shot;
		IsFiring = true;
		if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out Shot))
		{
			distanceFromTarget = Shot.distance;
			Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
		}
		Pistol.GetComponent<Animation>().Play("GunFire");
		yield return new WaitForSeconds(0.5f);
		GunShot.Play();
		IsFiring = false;
	}
}
