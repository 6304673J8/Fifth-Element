using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceBlock : MonoBehaviour
{
    public float destroying;
    public float destroyDelay = 0.01f;
    public Animator anim;
    [SerializeField] ParticleSystem steam;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Fire"))
        {
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        anim.SetTrigger("isDestroyed");
        destroying += Time.deltaTime;
        steam.Play();
        if (destroying >= destroyDelay)
        {
            Destroy(gameObject);
        }
    }
}
