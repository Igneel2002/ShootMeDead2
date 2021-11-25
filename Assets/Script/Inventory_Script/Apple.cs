using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public Shop SHOP;
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
                SHOP.apple += 1;
            }
        }
        else if (truth != true)
        {
            
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
