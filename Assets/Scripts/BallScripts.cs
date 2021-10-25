using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScripts : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            score++;
        }

        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            score = 0;
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
