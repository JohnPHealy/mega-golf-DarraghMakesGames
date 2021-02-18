using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudStick : MonoBehaviour
{

    //Calls 2 functions from within the BallMovement.cs script - one on enter (EnterMud, reduces shotPower) one on exit (ExitMud, reset shotPower to default)

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SendMessage("EnterMud");
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.SendMessage("ExitMud");
    }

}
