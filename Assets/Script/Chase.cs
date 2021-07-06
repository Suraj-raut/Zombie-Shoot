using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
	
	public Transform player;
	static Animator anim;
	public int EnemyHealth = 20;
	public GameObject TheEnemy;
	public int StatusCheck;
	public GameObject ZombieTigger;
	public AudioSource Roar1;
	public AudioSource Roar2;
	public AudioSource Roar3;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
		
    }
	
	
	public void DamageZombie (int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
		StartCoroutine(DamageDelay());
		
		
	}

    // Update is called once per frame
    void Update()
    {
		
		Roar2.Play();
		if(EnemyHealth > 0)
		{
		
        if(Vector3.Distance(player.position, this.transform.position) < 10)
		{
			
			Vector3 direction = player.position - this.transform.position;
			direction.y = 0;
			
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
			
			
			anim.SetBool("isIdeal",false);
			if(direction.magnitude < 5)
			{
				this.transform.Translate(0,0,0.05f);
				anim.SetBool("isWalking",true);
				anim.SetBool("isAttacking",false);
				Roar1.Play();
				
			}
			if(direction.magnitude < 2)
			{
				anim.SetBool("isAttacking",true);
				anim.SetBool("isWalking",false);
				Roar3.Play();
			}
		}
		else  
		{
			anim.SetBool("isIdeal",true);
			anim.SetBool("isWalking",false);
			anim.SetBool("isAttacking",false);
		}
		
		}
		
		 if (EnemyHealth == 0)
			{
			    anim.SetBool("isDeath",true);
				anim.SetBool("isWalking",false);
			    anim.SetBool("isAttacking",false);
			    StatusCheck = 2;
			    StartCoroutine(MonsterDeath());
			   
			}
		
		}
	
	IEnumerator MonsterDeath()
	{
		ZombieTigger.SetActive(false);
		yield return new WaitForSeconds(3);
		 TheEnemy.SetActive(false);
		
	}
	
	IEnumerator DamageDelay()
	{
		anim.SetBool("isDamage",true);
		yield return new WaitForSeconds(1);
		anim.SetBool("isDamage",false);
		
		
	}
	
    }

