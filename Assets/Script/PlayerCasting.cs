using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCasting : MonoBehaviour
{
  public static float DistancefromTarget;
	public float ToTarget;
	public int PlayerHealth = 100;
	public int HitByEnemy = 10;
	public GameObject HitScreen;
	public Slider HealthBar;
	public AudioSource Pain1;
	public AudioSource Pain3;
	public AudioSource Pain2;
	
	
	
	void Start()
	{
		
		HealthBar.minValue = 0;
		HealthBar.maxValue = 100;
		HealthBar.wholeNumbers = true;
		HealthBar.value = 100;
	}
	
    void Update()
    {
        RaycastHit Hit;
		if(Physics.Raycast(transform.position,  transform.TransformDirection(Vector3.forward), out Hit))
		{
			ToTarget = Hit.distance;
			DistancefromTarget = ToTarget;
				
		}
		
		
		if (PlayerHealth == 0)
			{
			  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		
			
    }
	
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Enemy")
		{
			PlayerHealth -= HitByEnemy;
			HealthBar.value -=10;
			int randomIndex = Random.Range(0,4);
			
			if(randomIndex == 0)
			{
				Pain1.Play();
			}
			
	       if(randomIndex == 2)
			{
				Pain2.Play();
			}
			if(randomIndex == 3)
			{
				Pain3.Play();
			}
			StartCoroutine(ColorChangeWhileHit());
		
		}
	}
	
	IEnumerator ColorChangeWhileHit()
	{
		yield return new WaitForSeconds(0.5f);
		
		HitScreen.GetComponent<Animation>().Play("HitByEnemy");
		
	}
}
