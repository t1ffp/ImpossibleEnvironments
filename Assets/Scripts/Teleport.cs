using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject theCart;
    public float tpZ;
    public float tpZ2;

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "tp1")
        {
            thePlayer.transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, thePlayer.transform.position.z - tpZ);
        }

        if (gameObject.tag == "tp2")
        {
            thePlayer.transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, thePlayer.transform.position.z - tpZ2);
        }

        if (gameObject.tag == "tp1")
        {
            theCart.transform.position = new Vector3(theCart.transform.position.x, theCart.transform.position.y, theCart.transform.position.z - tpZ);
        }

        if (gameObject.tag == "tp2")
        {
            theCart.transform.position = new Vector3(theCart.transform.position.x, theCart.transform.position.y, theCart.transform.position.z - tpZ2);
        }
    }
}
