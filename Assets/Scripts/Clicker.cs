using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update

    public int score;
    public TMP_Text scoreText;
    void Start()
    {
        scoreText.text = score.ToString();
    }

    void OnMouseDown()
    {
        score++;
    }
}
