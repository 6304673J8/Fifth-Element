using System.Collections;
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
        air_particles.Play();
    }

    public void WaterAtt(InputAction.CallbackContext ctx)
    {
        water_particles.Play();
    }
    public void FireAtt(InputAction.CallbackContext ctx)
    {
        fire_particles.Play();
    }
    public void EarthAtt(InputAction.CallbackContext ctx)
    {
        earth_particles.Play();
    }
}
