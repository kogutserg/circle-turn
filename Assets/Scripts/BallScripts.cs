using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(2);
        }
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
