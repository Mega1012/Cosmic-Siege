using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParallax : MonoBehaviour
{
    private Action action;
    [SerializeField] private float offsetX;
    [SerializeField] private bool ShouldStartOnStart;
    private Material material;

    private void Start()
    {
        EnviromentController.instanceEnviroment.parallaxEvent += PlayParallax;
        offsetX = 0.2f;
        PlayParallax(ShouldStartOnStart);
    }

    private void OnDestroy()
    {
        EnviromentController.instanceEnviroment.parallaxEvent -= PlayParallax;
    }


    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void FixedUpdate()
    {
        action?.Invoke();
    }
    private void TextureOffSet()
    {
        material.mainTextureOffset += new Vector2(offsetX * Time.deltaTime, 0);
    }

    public void PlayParallax(bool shouldPlay)
    {
        if (shouldPlay)
        {
            action = TextureOffSet;
        }
        else
        {
            action = null;
        }
    }
}
