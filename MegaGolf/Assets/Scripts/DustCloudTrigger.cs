using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCloudTrigger : MonoBehaviour
{

    ParticleSystem ps = GameObject.Find("ParticaleSystem-Object-Name").GetComponent<ParticleSystem>();


    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "bench")
        {
           ps.Play();
            
        }
 
    }

}
