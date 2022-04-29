using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEfects : MonoBehaviour
{
    public ParticleSystem collectParticle;
    public ParticleSystem collectParticle2;
    public ParticleSystem collectParticle3;

    private void Start()
    {
        collectParticle= GameObject.Find("Light").GetComponent<ParticleSystem>();
        collectParticle2= GameObject.Find("star").GetComponent<ParticleSystem>();
        collectParticle3 = GameObject.Find("Smoke").GetComponent<ParticleSystem>();
    }

    private void OnEnable()
    {
        Actions.OnHeightChanged += PlayHeightParticles;
        Actions.OnGameFinish += PlayFinishParticles;
    }

    private void OnDisable()
    {
        Actions.OnHeightChanged -= PlayHeightParticles;
        Actions.OnGameFinish -= PlayFinishParticles;
    }

    public void PlayHeightParticles(float x)
    {
        collectParticle.Play();
        collectParticle2.Play();
        
    }

    public void PlayFinishParticles()
    {
        collectParticle3.Play();
    }
}
