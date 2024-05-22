using TMPro;
using UnityEngine;

public class Sell : MonoBehaviour
{
    public TextMeshProUGUI MoneyText;

    float Money;

    private Case BackInv;

    public int i;

    public void OnClick()
    {
        Money += 10f;

        MoneyText.text = "Money: $" + Money;

        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        BackInv = GameObject.FindGameObjectWithTag("Backpack").GetComponent<Case>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            BackInv.isFull[i] = false;
        }
    }
}
