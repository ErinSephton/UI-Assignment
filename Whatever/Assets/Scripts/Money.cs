using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI MoneyText;

    public float MoneyNo = 100f;

    public int i;

    public bool Enough;
    
    public void ItemBuy()
    {
        MoneyNo -= 30f;

        MoneyText.text = "Money: $ " + MoneyNo;
    }

    public void EyeBuy()
    {
        MoneyNo -= 20f;

        MoneyText.text = "Money: $ " + MoneyNo;
    }

    public void UpBuy()
    {
        MoneyNo -= 40f;

        MoneyText.text = "Money: $ " + MoneyNo;
    }

    // Start is called before the first frame update
    void Start()
    {
        Enough = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(MoneyNo > 0)
        {
            Enough = true;
        }

        else
        {
            Enough = false;

            Debug.Log("No Money");
        }
    }
}
