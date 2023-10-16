using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonUI : MonoBehaviour
{

    public int playerMoney;
    public int firstauto;
    public int xxmultiplier = 0;
    public Text moneyText;
    public Text status;
    public Text perSec;

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

        perSec.text = ("per second: ") + firstauto.ToString();
    }


    public void AddMoney()
    {
        if (xxmultiplier >= 2)
        {
            playerMoney = playerMoney + 1 * xxmultiplier;
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
            xxmultiplier += 2;

        }
    }
}
