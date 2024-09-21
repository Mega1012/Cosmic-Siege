using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

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
        GSP += ((input.MovPlayer() * moveSpeed) * Time.deltaTime);
    }

    private void Update()
    {

    }

    public void Teste()
    {
        Instantiate(baseWeapon, tPosition.position, Quaternion.identity);
        PlayAudio();
    }
}
