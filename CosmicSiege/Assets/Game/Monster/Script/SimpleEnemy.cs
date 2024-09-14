using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : ATransform, IDamageble
{
    [SerializeField] private int life;

    public void TakeDamage(int damage, Vector3 position)
    {
        life -= damage;
        if (life <= 0)
        {
            GetBoxCollider2D.enabled = false;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Acertou mizeravi");
    }
}
