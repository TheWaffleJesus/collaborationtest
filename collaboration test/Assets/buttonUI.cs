using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonUI : MonoBehaviour
{

    public int playerMoney;
    public Text moneyText;
    public Text status;
    public int firstauto;


    void Start()
    {
        StartCoroutine(AddAutoMoney());
    }

    IEnumerator AddAutoMoney()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playerMoney += firstauto;
            moneyText.text = playerMoney.ToString();
        }
    }


    void Update()
    {
        if (playerMoney > 9)
        {
            status.text = "congrats ur not broke anymore";
        }
        else
        {
            status.text = "Get to work, bitch!";
        }
    }


    public void AddMoney()
    {
        playerMoney = playerMoney + 1;
        moneyText.text = playerMoney.ToString();

    }

    public void BuyFirstUpgrade()
    {
        if(playerMoney >= 10)
        {
            playerMoney -= 10;
            moneyText.text = playerMoney.ToString();
            firstauto += 1;
        }
    }
}
