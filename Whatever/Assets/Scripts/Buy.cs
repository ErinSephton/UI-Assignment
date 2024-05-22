using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public float Money = 100f;

    public TextMeshProUGUI MoneyText;

    

    public void HeartClick()
    {
        if (Money > 0)
        {
            Money -= 20f;

            MoneyText.text = "Funds: " + Money;

            Debug.Log(Money);
        }       
    }

    public void BrainClick()
    {
        if (Money > 0)
        {
            Money -= 30f;

            MoneyText.text = "Funds: " + Money;

            Debug.Log(Money);
        }       
    }

    public void FootClick()
    {
        if (Money > 0)
        {
            Money -= 25f;

            MoneyText.text = "Funds: " + Money;

            Debug.Log(Money);
        }        
    }

    public void Click()
    {
        if (Money > 0)
        {
            Money -= 15f;

            MoneyText.text = "Funds: " + Money;

            Debug.Log(Money);
        }     
    }

    public void UpgradeClick()
    {
        if (Money > 0)
        {
            Money -= 40f;

            MoneyText.text = "Funds: " + Money;

            Debug.Log(Money);
        }             
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
