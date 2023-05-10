using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rd;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody>();

        //player.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetAxis("Horizontal") > 0)
            {
                rd.AddForce(Vector3.right * speed);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                rd.AddForce(-Vector3.right * speed);
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                rd.AddForce(Vector3.forward * speed);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                rd.AddForce(-Vector3.forward * speed);
            }
    }
    

}
