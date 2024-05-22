using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootMove : MonoBehaviour
{
    private Fridge FridgeInv;

    private Case CaseInv;

    public GameObject Item;    

    public int i; 

    //bool Place;

    public bool InFridge;
    
    // Start is called before the first frame update
    void Start()
    {
        FridgeInv = GameObject.FindGameObjectWithTag("Fridge").GetComponent<Fridge>();

        CaseInv = GameObject.FindGameObjectWithTag("Case").GetComponent<Case>();

        //Place = false;
    }

    public void OnClick()
    {
        if (!InFridge)
        {
            Debug.Log("Going to Fridge");
            MoveItemToFridge();
        }
        else
        {
            Debug.Log("Going to Case");
            MoveItemToCase();
        }
    }


    private void MoveItemToFridge()
    {
        for (int i = 0; i < FridgeInv.slots.Length; i++)
        {
            if (FridgeInv.isFull[i] == false)
            {
                FridgeInv.isFull[i] = true;
               
                Instantiate(Item, FridgeInv.slots[i].transform);

                Destroy(gameObject);

                InFridge = true;

                return;
            }
        }
    }
    private void MoveItemToCase()
    {
        for (int i = 0; i < CaseInv.slots.Length; i++)
        {
            if (CaseInv.isFull[i] == true)
            {
                CaseInv.isFull[i] = false;

                Instantiate(Item, CaseInv.slots[i].transform);

                Destroy(gameObject);

                InFridge = false;

                return;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
