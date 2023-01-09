using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContol : MonoBehaviour
{

    public GameObject gameOvertext;

    private int score = 0;
    public bool gameOver = false;
    public float scrollspeed = -1.5f;


    void Awake()
    {

        if (instance == null)

            instance = this;

        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {

        if (gameOver == true && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}

