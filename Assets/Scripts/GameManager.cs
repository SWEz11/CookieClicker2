using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;
    void Update()
    {
        scoreText.text = score.ToString();
        if(transform.localScale.x > 0.6878f)
        {
            transform.localScale -= Vector3.one * 0.08f;
        }
    }

    void OnMouseDown()
    {
        transform.localScale = Vector3.one * 1.5f;
        score++;
    }
}
