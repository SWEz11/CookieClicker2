using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;
    public int clicksperclick;
    public int[] clickgoal;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer particalRenderes;
    public Sprite[] nextcookie;
    public Sprite[] nextpartical;
    int skinIndex;
    public GameObject unlockpartical;

    void Start()
    {
        Load();
        clicksperclick = 1;
    }
    void Update()
    {
        scoreText.text = score.ToString();
        if(transform.localScale.x > 0.6878f)
        {
            transform.localScale -= Vector3.one * 0.1f;
        }
        SaveScore();

        if(skinIndex < clickgoal.Length && score >= clickgoal[skinIndex])
        {
            unlockpartical.SetActive(true);
            spriteRenderer.sprite = nextcookie[skinIndex++];
            particalRenderes.sprite = nextpartical[skinIndex++];
        }
    }

    void OnMouseDown()
    {
        transform.localScale = Vector3.one * 1.5f;
        score += clicksperclick;
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", score);
    }

    void OnApplicationQuit()
    {
        SaveScore();
    }

    void Load()
    {
        score = PlayerPrefs.GetInt("score");
    }
}
