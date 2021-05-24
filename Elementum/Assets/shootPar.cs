﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shootPar : MonoBehaviour
{
    [SerializeField] ParticleSystem water_particles;
    [SerializeField] ParticleSystem fire_particles;
    [SerializeField] ParticleSystem earth_particles;
    [SerializeField] ParticleSystem air_particles;

    public Animator animator;

    public void AirAtt(InputAction.CallbackContext ctx)
    {
        FindObjectOfType<SoundManager>().Play("AirAttack");
        animator.SetTrigger("AttackA");
        air_particles.Play();
    }

    public void WaterAtt(InputAction.CallbackContext ctx)
    {
        FindObjectOfType<SoundManager>().Play("WaterAttack");
        animator.SetTrigger("Attack_W");
        water_particles.Play();
    }
    public void FireAtt(InputAction.CallbackContext ctx)
    {
        FindObjectOfType<SoundManager>().Play("FireAttack");
        animator.SetTrigger("Attack_F");
        fire_particles.Play();
    }
    public void EarthAtt(InputAction.CallbackContext ctx)
    {
        FindObjectOfType<SoundManager>().Play("EarthAttack");
        animator.SetTrigger("AttackE");
        earth_particles.Play();
    }
}
