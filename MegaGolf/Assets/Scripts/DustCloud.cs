using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DustCloud : MonoBehaviour
{

    [SerializeField] private UnityEvent collidedDust;

    private void OnTriggerEnter(Collider other)
    {
        collidedDust.Invoke();
        Debug.Log("Dust");
    }


}
