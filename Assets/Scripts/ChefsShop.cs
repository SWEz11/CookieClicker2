using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button upgradeButton;
    public TMP_Text upgradePriceText;
    public int upgradecount;
    public int upgradePrice;
    public Button chefButton;
    public GameManager gameManager;
    public GameObject chef;
    public int chefcount;
    public TMP_Text chefcountText;
    public TMP_Text chefpriceText;
    public int chefprice;
    public float clickTimer;
    public bool setchef;
    public float time;
    void Start()
    {
        Load();
        setchef = false;
        chefprice = 10;
        chefButton.interactable = false;
        time = 1;
        upgradeButton.interactable = false;
        upgradePrice = 400;
    }

    // Update is called once per frame
    void Update()
    {
        chefpriceText.text = chefprice.ToString();
        chefcountText.text = chefcount.ToString();
        upgradePriceText.text = upgradePrice.ToString();

        // TIMER
        clickTimer += Time.deltaTime;

        if (setchef == true)
        {
            if (clickTimer > time)
            {
                gameManager.score += chefcount;
                clickTimer = 0;
            }
        }
        if (gameManager.score >= chefprice)
        {
            chefButton.interactable = true;
            if (chefButton.interactable == true)
            {
                chefButton.interactable = true;
            }
        }
        else
        {
            chefButton.interactable = false;
        }

        if(gameManager.score >= upgradePrice)
        {
            if(chefcount >= 8)
            {
                upgradeButton.interactable = true;
            }
        }
        else
        {
            upgradeButton.interactable = false;
        }

    }
    public void buyChef()
    {
        gameManager.score -= chefprice;
        chefprice *= 2;
        chefcount++;
        setchef = true;
        gameManager.clicksperclick += chefcount;
        SaveChefCount();
    }
    
    void OnMouseDown()
    {
        buyChef();
    }

    public void Upgrade()
    {
        time = 0.5f;
        gameManager.score -= upgradePrice;
        upgradePrice *= 5;
        chefprice *= 3;
        upgradecount++;
        SaveChefUpgrade();
    }

    void SaveChefCount()
    {
        PlayerPrefs.SetInt("chefcount", chefcount);
    }

    void SaveChefPrice()
    {
        PlayerPrefs.SetInt("chefprice", chefprice);
    }

    void SaveChefUpgrade()
    {
        PlayerPrefs.SetInt("chefupgrade", upgradecount);
    }

    void OnApplicationQuit()
    {
        SaveChefCount();
        SaveChefUpgrade();
    }

    void Load()
    {
        chefcount = PlayerPrefs.GetInt("chefcount");
        upgradecount = PlayerPrefs.GetInt("chefupgrade");
        chefprice = PlayerPrefs.GetInt("chefprice");
    }

}
