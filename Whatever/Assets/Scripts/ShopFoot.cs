using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShopFoot : MonoBehaviour
{
    private Case CaseInv;

    private Buy BuyScript;

    public int i;

    public GameObject Slot;

    public GameObject Item;

    float Money;

    // Start is called before the first frame update
    void Start()
    {
        CaseInv = GameObject.FindGameObjectWithTag("Case").GetComponent<Case>();

        BuyScript = GameObject.FindGameObjectWithTag("Money").GetComponent<Buy>();       
    }

    public void OnClick()
    {
        /*if (Money > 0)
        {
            for (int i = 0; i < CaseInv.slots.Length; i++)
            {
                if (CaseInv.isFull[i] == false)
                {
                    CaseInv.isFull[i] = true;

                    Instantiate(Item, CaseInv.slots[i].transform);

                    Slot.GetComponent<Money>().EyeBuy();

                    break;
                }
            }
        }*/

        /*for (int i = 0; i < CaseInv.slots.Length; i++)
        {
            if (CaseInv.isFull[i] == false)
            {
                CaseInv.isFull[i] = true;

                Instantiate(Item, CaseInv.slots[i].transform);

                Slot.GetComponent<Money>().EyeBuy();

                break;
            }
        }*/

        for (int i = 0; i < CaseInv.slots.Length; i++)
        {         
            if (CaseInv.isFull[i] == false)
            {
                CaseInv.isFull[i] = true;

                Instantiate(Item, CaseInv.slots[i].transform);

                Debug.Log("Purchased");

                //Destroy(gameObject);

                //InFridge = false;

                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
