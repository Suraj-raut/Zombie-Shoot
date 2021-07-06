using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{
	
	public GameObject ZombieTigger;
	public GameObject Monster;
	
    void OnTriggerEnter()
	{
		Monster.SetActive(true);
	}
}
