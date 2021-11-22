using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    Shop SHOP;
    Menu MENU;
    [SerializeField]
    private GameObject Invent;
    [SerializeField]
    private GameObject AppleSlot;
    public bool inv;
    public Text Appletext;
    // Start is called before the first frame update
    void Start()
    {
        Invent.SetActive(false);
        inv = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if (inv == true)
            {
                inv = false;
                Invent.SetActive(true);
                Time.timeScale = 0;
                if(SHOP.apple == 0)
                {
                    AppleSlot.SetActive(false);
                }
                else if (SHOP.apple != 0)
                {
                    AppleSlot.SetActive(true);
                }
            }

            else if (inv != true)
            {
                Invent.SetActive(false);
                Time.timeScale = 1;
                inv = true;
            }
        }
        Appletext.text = "Apples " + (int)SHOP.apple;
    }

    public void use()
    {
        if(SHOP.apple >= 1)
        {
            SHOP.apple -= 1;
            MENU.HEALTH += 10;
            if(SHOP.apple == 0)
            {
                AppleSlot.SetActive(false);
            }
            else if(SHOP.apple != 0)
            {
                AppleSlot.SetActive(true);
            }
        }
    }

    public void Drop()
    {
        if(SHOP.apple >= 1)
        {
            SHOP.apple -= 1;
            
            if(SHOP.apple == 0)
            {
                AppleSlot.SetActive(false);
            }
            else if (SHOP.apple != 0)
            {
                AppleSlot.SetActive(true);
            }
        }
    }
}
