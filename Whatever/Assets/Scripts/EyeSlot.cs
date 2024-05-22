using TMPro;
using UnityEngine;

/*public class EyeSlot : MonoBehaviour
{
    private Backpack BackInv;

    private Money MoneyScript;

    public GameObject ItemButton;

    public TextMeshProUGUI MoneyText;

    public float Money = 100f;

    public int i;

    public GameObject Slot;

    //public GameObject Parent;

    // Start is called before the first frame update
    void Start()
    {
        BackInv = GameObject.FindGameObjectWithTag("Backpack").GetComponent<Backpack>();

        MoneyScript = GameObject.FindGameObjectWithTag("Money").GetComponent<Money>();
    }

    public void OnClick()
    {
        if (Money > 0)
        {
            Debug.Log ("Purchase!");

            for (int i = 0; i < BackInv.slots.Length; i++)
            {
                if (BackInv.isFull[i] == false)
                {
                    BackInv.isFull[i] = true;

                    //ItemButton.parent = ChestInv.slots[i];

                    //ItemButton.transform.position = ChestInv.slots[i].transform.position;

                    Instantiate(ItemButton, BackInv.slots[i].transform);

                    //Money -= 20f;

                    //MoneyText.text = "Money: $ " + Money;

                    Slot.GetComponent<Money>().EyeBuy();

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
