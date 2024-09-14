using UnityEngine;

public class AWeapon : ATransform
{
    [Header("Variables")]
    [SerializeField] protected int damage;
    [SerializeField] protected int timerToDestroy;
    [SerializeField] protected int speedX;
    [SerializeField] protected int speedY;
    [SerializeField] protected LayerMask layerMask;

    protected void TimeToDestroyer()
    {
        timerToDestroy--;
        if(timerToDestroy <= 0)
            Destroy(gameObject);
    }
    protected void Move()
    {
        GSX += speedX * Time.deltaTime;
        GSY += speedY * Time.deltaTime;
    }
}
