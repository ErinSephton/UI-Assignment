using TMPro;
using UnityEditor;
using UnityEngine;

/*public class Slot : MonoBehaviour
{
    private Backpack BackInv;

    private Money MoneyScript;

    public GameObject ItemButton;

    public GameObject EyeButton;

    public TextMeshProUGUI MoneyText;

    public float Money;

    public int i;

    public GameObject ItemSlot;


    // Start is called before the first frame update
    void Start()
    {     
        BackInv = GameObject.FindGameObjectWithTag("Backpack").GetComponent<Backpack>();

        MoneyScript = GameObject.FindGameObjectWithTag("Money").GetComponent<Money>();

        Money = 100f;
    }

    public void OnItemClick()
    {
        if (Money > 0)
        {
            Debug.Log("Purchase!");

            Money -= 30f;

            MoneyText.text = "Money: $ " + Money;

            for (int i = 0; i < BackInv.slots.Length; i++)
            {
                if (BackInv.isFull[i] == false)
                {
                    BackInv.isFull[i] = true;

                    //ItemButton.parent = ChestInv.slots[i];

                    //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                    Instantiate(ItemButton, BackInv.slots[i].transform);

                    ItemSlot.GetComponent<Money>().ItemBuy();

                    //Destroy(gameObject);

                    break;
                }
            }
        }
        
    }
    public void OnEyeClick()
    {
        if (Money > 0)
        {
            Debug.Log("Purchase!");

            Money -= 20f;

            MoneyText.text = "Money: $ " + Money;

            for (int i = 0; i < BackInv.slots.Length; i++)
            {
                if (BackInv.isFull[i] == false)
                {
                    BackInv.isFull[i] = true;

                    //ItemButton.parent = ChestInv.slots[i];

                    //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                    Instantiate(EyeButton, BackInv.slots[i].transform);

                    //Slot.GetComponent<Money>().EyeBuy();

                    //Destroy(gameObject);

                    break;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}*/
