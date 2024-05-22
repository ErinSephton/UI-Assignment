using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpSlot : MonoBehaviour
{
    private Case BackInv;

    //private Upgrade UpScript;

    public GameObject ItemButton;

    public TextMeshProUGUI MoneyText;

    public float Money = 100f;

    public int i;

    public Button Buy;

    public Button Upgrader;

    //public GameObject Parent;

    // Start is called before the first frame update
    void Start()
    {
        BackInv = GameObject.FindGameObjectWithTag("Backpack").GetComponent<Case>();

        //UpScript = GameObject.FindGameObjectWithTag("Slot").GetComponent<Upgrade>();
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

                    Money -= 40f;

                    MoneyText.text = "Money: $ " + Money;                   

                    //Destroy(gameObject);

                    break;
                }
            }

            //Upgrader.interactable = true;

            Destroy(Buy);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
