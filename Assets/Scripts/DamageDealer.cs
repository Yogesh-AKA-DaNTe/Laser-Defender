using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Variable for storing damage dealt by projectiles
    [SerializeField] int damage = 100;

    // Function get the damage
    public int GetDamage()
    {
        return damage;
    }

    // Function to destroy the projectile after it hits something
    public void Hit()
    {
        Destroy(gameObject);
    }
}
