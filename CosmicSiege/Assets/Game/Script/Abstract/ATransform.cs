using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(AudioSource))]
public abstract class ATransform : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private BoxCollider2D boxCollider2d;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        boxCollider2d = GetComponentInChildren<BoxCollider2D>();
        audioSource = GetComponentInChildren<AudioSource>();
    }


    //Essa funcao vai ser removida depois. Tem um jeito melhor de trabalhar com audio
    public void PlayAudio()
    {
        audioSource.Play();
    }

    /// <summary>
    /// Animator
    /// </summary>
    public Animator GetAnim => animator;
    public bool IsName(int hash) => animator.GetCurrentAnimatorStateInfo(0).shortNameHash == hash;
    public float NormalizedTime() => animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    public void Trigger(int hash) => animator.SetTrigger(hash);

    /// <summary>
    /// Sprite Renderer
    /// </summary>
    public SpriteRenderer GetSR() => spriteRenderer;
    public void FlipX(bool flip) => spriteRenderer.flipX = flip;
    public bool GetFlipX() => spriteRenderer.flipX;
    public void FlipY(bool flip) => spriteRenderer.flipY = flip;
    public bool GetFlipY() => spriteRenderer.flipY;


    public BoxCollider2D GetBoxCollider2D => boxCollider2d;


    /// <summary>
    /// Transform
    /// </summary>
    public float GSX { get => transform.position.x; set => transform.position = new Vector3(value,GSY,GSZ); }
    public float GSY { get => transform.position.y; set => transform.position = new Vector3(GSX,value,GSZ); }
    public float GSZ { get => transform.position.z; set => transform.position = new Vector3(GSX,GSY,value); }
    public Vector2 GSP { get => transform.position; set => transform.position = new Vector2(value.x,value.y); }
}
