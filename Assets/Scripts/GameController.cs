using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int points1, points2;
    public Text text1Points;
    public Text text2Points;
    public GameObject gameWin;

    public void PointCounter(string player)
    {      
       
        if (player == "text1")
        {
            points1++;
            text1Points.text = "Player 1:  " + points1;
        }
       else 
        {
            points2++;
            text2Points.text = "Player 2: " + points2;

        }
        if (points1 >= 5)
        {
            GameWin();
        }
        else if (points2 >= 5)
        {
            GameWin();
        }

    }

    private void Start()
    {
        Time.timeScale = 1;
        gameWin.SetActive(false);
    }

    private void GameWin()
    {
        Time.timeScale = 0;
        gameWin.SetActive(true);
    }

   // public void GameLoose()
    //{
  //      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   // }

    public void GameRestart()
    {
        Time.timeScale = 1;
        gameWin.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
