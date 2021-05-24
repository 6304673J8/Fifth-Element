using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airblockParent : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Air"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
