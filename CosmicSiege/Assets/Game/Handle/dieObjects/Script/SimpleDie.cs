using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimpleDie : ATransform
{
    protected override void Awake()
    {
        base.Awake();
        
    }

    private void FixedUpdate()
    {
        if (IsName(HashAnimationKeys.destroy))
        {
            Destroy(gameObject);
        }
    }
}
