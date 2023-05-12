using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitMenu : MonoBehaviour
{
    public Button exitbtn;

    // Start is called before the first frame update
    void Start()
    {
        exitbtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitbtn.gameObject.SetActive(true);
        }
    }
}
