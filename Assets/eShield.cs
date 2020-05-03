﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eShield : MonoBehaviour
{

    int hp = 1;

    private float damageTime;
    private bool recieveDamage;

    private void FixedUpdate()
    {
        //So no double hits
        if (damageTime > 0.1)
        {
            damageTime = 0;
            recieveDamage = true;
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (recieveDamage)
        {
            Debug.Log("SHIELD HIT " + this.name);

            this.hp--;

            if (this.hp < 1)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
