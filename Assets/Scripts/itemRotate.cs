using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class itemRotate : MonoBehaviour
{
    void Update()
    {

        transform.Rotate(0f, 0f, 15f * Time.deltaTime, Space.Self);
    }
}
