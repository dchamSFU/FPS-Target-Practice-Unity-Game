using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource AmmoSound;
    public bool usable = true;
    private IEnumerator OnTriggerEnter(Collider other)
    { //Now includes Respawning action!
        if (usable)
        {
            AmmoSound.Play();
            GlobalAmmo.CurrentAmmo += 10;
            usable = false;
            Vector3 current = transform.position;
            transform.position = new Vector3(1000, 1000, 1000);

            yield return new WaitForSeconds(5);
            usable = true;
            transform.position = current;
        }

    }

}
