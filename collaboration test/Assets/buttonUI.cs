using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonUI : MonoBehaviour
{

    public int playerMoney;
    public int firstauto;
    public bool xxmultiplier;
    public Text moneyText;
    public Text status;

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
        if (xxmultiplier == true)
        {
            playerMoney = playerMoney + 1 * 2;
            moneyText.text = playerMoney.ToString();
        }
        else
        {
            playerMoney = playerMoney + 1;
            moneyText.text = playerMoney.ToString();
        }
        
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

    public void BuySecondUpgrade()
    {
        if(playerMoney >= 50)
        {
            playerMoney -= 50;
            moneyText.text = playerMoney.ToString();
            xxmultiplier = true;

        }
    }
}
