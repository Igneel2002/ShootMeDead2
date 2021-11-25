using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public AppleSpawner[] app1;
    public Shop SHOP;
    public Menu MENU;
    [SerializeField]
    private GameObject Invent;
    [SerializeField]
    private GameObject AppleSlot;
    public GameObject drop;
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
            print("apple" + SHOP.apple);
            if (inv == true)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                inv = false;
                Invent.SetActive(true);
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
                Screen.lockCursor = true;
                Cursor.visible = false;
                Invent.SetActive(false);
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
            if (app1.Length > 0)
            {
                GameObject prefab = app1[Random.Range(0, app1.Length)].applefab;
                if (prefab != null)
                {
                    Transform apple = Instantiate(prefab.transform, drop.transform.position, Quaternion.identity, transform);
                }
            }
            transform.position = drop.transform.position;
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
