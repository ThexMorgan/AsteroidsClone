﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private void Update()
    {

        this.gameObject.GetComponent<ProjectileMovementComponent>().UpdateProjectileMovement(this);

    }

    
    
}