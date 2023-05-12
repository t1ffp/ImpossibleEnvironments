using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartTP : MonoBehaviour
{
    public GameObject theCart;
    public float tpZ;
    public float tpZ2;



    private void OnTriggerEnter(Collider other)
    {

        if (gameObject.tag == "ctp1")
        {
            theCart.transform.position = new Vector3(theCart.transform.position.x, theCart.transform.position.y, theCart.transform.position.z - tpZ);
        }

        if (gameObject.tag == "ctp2")
        {
            theCart.transform.position = new Vector3(theCart.transform.position.x, theCart.transform.position.y, theCart.transform.position.z - tpZ2);
        }
    }
}
