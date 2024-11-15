using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button chefbutton;
    public GameManager gameManager;
    public GameObject chef;
    public int chefcount;
    public TMP_Text chefcountText;
    public TMP_Text chefpriceText;
    public int chefprice;
    public float clickTimer;
    public bool setchef;
    void Start()
    {
        setchef = false;
        chefprice = 10;
        chefbutton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        chefpriceText.text = chefprice.ToString();
        chefcountText.text = chefcount.ToString();

        // TIMER
        clickTimer += Time.deltaTime;

        if (setchef == true)
        {
            if (clickTimer > 1f)
            {
                gameManager.score += chefcount;
                clickTimer = 0;
            }
        }
        if (gameManager.score >= chefprice)
        {
            chefbutton.interactable = true;
            if (chefbutton.interactable == true)
            {
                chefbutton.interactable = true;
            }
        }
        else
        {
            chefbutton.interactable = false;
        }
    }
    public void buyChef()
    {
        gameManager.score -= chefprice;
        chefprice *= 2;
        chefcount++;
        setchef = true;
        gameManager.clicksperclick += chefcount;
    }
    
    void OnMouseDown()
    {
        buyChef();
    }
}
