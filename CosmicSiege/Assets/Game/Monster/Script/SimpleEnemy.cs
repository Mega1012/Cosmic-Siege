using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : ATransform, IDamageble
{
    [Header("Game Object")]
    [SerializeField] private GameObject dieObject;
    [Header("Variables")]
    [SerializeField] private int life;
    [SerializeField] Vector3 localScaleDieObject;

    public void TakeDamage(int damage, Vector3 position)
    {
        life -= damage;
        if (life <= 0)
        {
            GetBoxCollider2D.enabled = false;
            GameObject die = Instantiate(dieObject,transform.position,Quaternion.identity);
            die.transform.localScale = localScaleDieObject;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Acertou mizeravi");
    }
}
