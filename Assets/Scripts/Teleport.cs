using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //public Transform teleportTarget;
    public GameObject thePlayer;
   
    

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = new Vector3(thePlayer.transform.position.x + 35, thePlayer.transform.position.y, thePlayer.transform.position.z);
    }
}
