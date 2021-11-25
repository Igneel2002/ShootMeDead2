using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public bool truth;
    // Start is called before the first frame update
    void Start()
    {
        truth = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (truth == true)
        {
            if (Input.GetKeyDown("e"))
            {
                Destroy(gameObject);
            }
        }
        else if (truth != true)
        {
            print("That won't work silly");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        truth = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        truth = false;
    }
}
