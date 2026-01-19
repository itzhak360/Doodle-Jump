using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0f;
    public Text scoreText;

    private void Update()
    {
        if (transform.position.y > score) {
            score = transform.position.y;
            scoreText.text = "Score:" + Mathf.RoundToInt(score).ToString();
        }
        
    }
}
