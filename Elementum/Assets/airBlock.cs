using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airBlock : MonoBehaviour
{
    public float activating;
    public float activateDelay = 0.01f;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Fire"))
        {
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        anim.SetTrigger("isDestroyed");
        activating += Time.deltaTime;
        if (activating >= activateDelay)
        {
            Destroy(gameObject);
        }
    }
}
