using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeControl : MonoBehaviour
{
    public GameObject cart;
    public GameObject cartCam;
    public GameObject player;
    public GameObject cartTp1;
    public GameObject cartTp2;
    bool grantAccess= false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            grantAccess = !grantAccess;
           
        }

        if (grantAccess)
        {
            player.gameObject.SetActive(false);
            cartCam.SetActive(true);
            cart.gameObject.GetComponent<CartController>().enabled = true;
            player.transform.position = cart.transform.position;
            cartTp1.gameObject.SetActive(true);
            cartTp2.gameObject.SetActive(true);
        }
        else
        {
            cart.gameObject.GetComponent<CartController>().enabled = false;
            player.gameObject.SetActive(true);
            cartCam.gameObject.SetActive(false);
            cartTp1.gameObject.SetActive(false);
            cartTp2.gameObject.SetActive(false);
        }
    }           
}
