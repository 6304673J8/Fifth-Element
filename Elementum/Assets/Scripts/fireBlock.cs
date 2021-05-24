using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBlock : MonoBehaviour
{
    public float destroying;
    public float destroyDelay = 0.01f;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Water"))
        {
            DestroyObject();
        }
    }

    private void DestroyObject()
    {
        anim.SetTrigger("isDestroyed");
        destroying += Time.deltaTime;
        if (destroying >= destroyDelay)
        {
            Destroy(gameObject);
        }
    }
}
