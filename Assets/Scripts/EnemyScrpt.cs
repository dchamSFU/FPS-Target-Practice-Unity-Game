﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScrpt : MonoBehaviour
{
    // Start is called before the first frame update
    public int EnemyHealth = 10;
    public AudioSource Death;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            Death.Play(); //Deathsound effects!
            gameObject.SetActive(false);
        }
    }
}
