using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject chef;
    public int chefcount;
    public TMP_Text chefcountText;
    public TMP_Text chefpriceText;
    public int chefprice;
    public float clickTimer;
    void Start()
    {
        chefprice = 10;
    }

    // Update is called once per frame
    void Update()
    {
        chefpriceText.text = chefprice.ToString();
        chefcountText.text = chefcount.ToString();
        if (chefcount >= 1) 
        {
            clickTimer += Time.deltaTime;
            if (clickTimer > 1f)
            {
                gameManager.score++;
                clickTimer = 0;
            }
        }
    }

    void OnMouseDown()
    {
        if(gameManager.score >= chefprice)
        {
            gameManager.score -= chefprice;
            chefprice *= 2;
            chefcount++;
        }
    }
}
