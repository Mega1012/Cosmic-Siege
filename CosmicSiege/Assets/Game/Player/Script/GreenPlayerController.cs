using UnityEngine;

public class GreenPlayerController : ATransform
{

    [Header("Position")]
    [SerializeField] private Transform tPosition;
    [Header("Prefab")]
    [SerializeField] private GameObject baseWeapon;
    [Header("Variables")]
    [SerializeField] private float moveSpeed;

    /// <summary>
    /// Handles
    /// </summary>
    private PlayerInput input;


    protected override void Awake()
    {
        base.Awake();
        input = new();
    }

    void FixedUpdate()
    {
        GSP+= ((input.MovPlayer() * moveSpeed) * Time.deltaTime);
    }

    public void Teste()
    {
        Debug.Log("Teste Button");
        Instantiate(baseWeapon,tPosition.position,Quaternion.identity);
        PlayAudio();
    }
}
