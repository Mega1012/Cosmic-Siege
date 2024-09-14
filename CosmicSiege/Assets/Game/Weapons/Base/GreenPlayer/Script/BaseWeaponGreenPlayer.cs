using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeaponGreenPlayer : AWeapon
{
    private void FixedUpdate()
    {
        TimeToDestroyer();
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dar dano");
        IDamageble d = collision.GetComponent<IDamageble>();
        if (d != null)
        {
            d.TakeDamage(damage, transform.position);
        }
        
    }
}
