using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentController : MonoBehaviour
{
    public static EnviromentController instanceEnviroment;
    public delegate void ParallaxEventFunc(bool shouldPlayParallax);
    public event ParallaxEventFunc parallaxEvent;

    private void Awake()
    {
        instanceEnviroment = this;
    }

    public void PlayParallax(bool shouldPlayParallax)
    {
        parallaxEvent(shouldPlayParallax);
    }
}
