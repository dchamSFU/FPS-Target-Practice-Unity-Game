using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour //This GunFire is the name of your C# file!!! 
{

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(GlobalAmmo.CurrentAmmo > 0)
            {
                AudioSource gunsound = GetComponent<AudioSource>();
                gunsound.Play();
                GetComponent<Animation>().Play("Gunshot"); //attention HERE!!! the name must be the folder you have for your animation!!!
                GlobalAmmo.CurrentAmmo -= 1;
            }
        }
    }
}