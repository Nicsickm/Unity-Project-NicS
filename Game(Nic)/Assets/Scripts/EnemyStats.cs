using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

    public int StartingHealth;
    int CurrentHealth;

	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
	}
	
    public void UpdateHealth(int Amount)
    {
        CurrentHealth = CurrentHealth + Amount;
        if(CurrentHealth <= 0)
        {
            Death();
        }
    }
	
    void Death()
    {
        gameObject.SetActive(false);
    }
	
}
