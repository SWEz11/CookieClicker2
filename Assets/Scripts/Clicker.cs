using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text scoreText;
    public int score;
    private void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnMouseDown()
    {
        score++;
    }
}
