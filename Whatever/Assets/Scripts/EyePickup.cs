using UnityEngine;

public class EyePickup : MonoBehaviour
{
    private Fridge ChestInv;

    private Case BackInv;

    public GameObject ItemButton;

    public bool InChest;

    public int i;

    // Start is called before the first frame update
    void Start()
    {
        InChest = true;

        ChestInv = GameObject.FindGameObjectWithTag("Chest").GetComponent<Fridge>();

        BackInv = GameObject.FindGameObjectWithTag("Backpack").GetComponent<Case>();
    }

    public void OnClick()
    {
        if (InChest == false)
        {
            Debug.Log("Going to Chest");

            for (int i = 0; i < ChestInv.slots.Length; i++)
            {
                if (ChestInv.isFull[i] == false)
                {
                    ChestInv.isFull[i] = true;

                    //ItemButton.parent = ChestInv.slots[i];

                    //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                    Instantiate(ItemButton, ChestInv.slots[i].transform);

                    Destroy(gameObject);                   

                    break;                    
                }                

                /*else if (ChestInv.isFull[i] == true)
                {
                    ChestInv.isFull[i] = false;
                }*/

                /*if (transform.childCount == 0)
                {
                    ChestInv.isFull[i] = false;
                }*/

                //InChest = true;
            }

            /*for (int i = 0; i < ChestInv.slots.Length; i++)
            {
                if (ChestInv.isFull[i] == false)
                {
                    ChestInv.isFull[i] = true;

                    //ItemButton.parent = ChestInv.slots[i];

                    //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                    Instantiate(ItemButton, ChestInv.slots[i].transform, false);

                    Destroy(gameObject);

                    break;
                }

                else if (ChestInv.isFull[i] == true)
                {
                    ChestInv.isFull[i] = false;
                }

                if (transform.childCount == 0)
                {
                    BackInv.isFull[i] = false;
                }
            }

            //InChest = true;
        }*/

            if (InChest == true)
            {
                Debug.Log("Going to Backpack");

                for (int i = 0; i < BackInv.slots.Length; i++)
                {
                    if (BackInv.isFull[i] == false)
                    {
                        BackInv.isFull[i] = true;

                        //ItemButton.parent = ChestInv.slots[i];

                        //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                        Instantiate(ItemButton, BackInv.slots[i].transform);

                        Destroy(gameObject);

                        break;
                    }

                    InChest = false;                    

                    /*else if (ChestInv.isFull[i] == true)
                    {
                        ChestInv.isFull[i] = false;
                    }

                    if (transform.childCount == 0)
                    {
                        BackInv.isFull[i] = false;
                    }*/
                }

                //InChest = false;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
