using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonUI : MonoBehaviour
{

    public int playerMoney;
    public Text moneyText;
    public Text status;


    void Start()
    {
        
    }


    void Update()
    {
        if (playerMoney > 9)
        {
            status.text = "congrats ur not broke anymore";
        }
        else
        {
            status.text = "get to work bitch";
        }
    }

    public void AddMoney()
    {
        playerMoney = playerMoney + 1;
        moneyText.text = playerMoney.ToString();

    }
}
