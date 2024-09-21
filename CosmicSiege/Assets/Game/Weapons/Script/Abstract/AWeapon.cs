using UnityEngine;

public class AWeapon : ATransform
{
    [Header("Damage")]
    [SerializeField] protected int damage;
    [SerializeField] protected int timerToDestroy;

    [Header("Speed")]
    [SerializeField] protected int speedX;
    [SerializeField] protected int speedY;

    [Header("Audio")]
    [SerializeField] protected bool shoudPlayAudioOnAwake;
    [SerializeField] protected int indexAudio;
    [SerializeField] protected float volumeTimeStartAt;

    [Header("Collision")]
    [SerializeField] protected LayerMask layerMask;


    protected override void Awake()
    {
        base.Awake();
        if(shoudPlayAudioOnAwake)
        {
            HAudio.PlayAudio(indexAudio,volumeTimeStartAt);
        }
    }

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
