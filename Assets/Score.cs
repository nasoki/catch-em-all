using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public static int score;
    public static int life;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
        life = 3;
        //gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life;

        if (life < 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }
}
