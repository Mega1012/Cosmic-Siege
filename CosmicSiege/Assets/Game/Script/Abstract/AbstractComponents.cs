using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractComponents : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public Animator GetAnim => animator;
    public bool IsName(int hash) => animator.GetCurrentAnimatorStateInfo(0).shortNameHash == hash;
    public float NormalizedTime() => animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    //public void Trigger(int hash)
    public SpriteRenderer GetSR() => spriteRenderer;
    public void FlipX(bool flip) => spriteRenderer.flipX = flip;
    public bool GetFlip() => spriteRenderer.flipX;
}
