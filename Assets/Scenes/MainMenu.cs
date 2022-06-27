using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Player2Game()
    {
        Debug.Log("button");
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("button1");
        Application.Quit();
    }

    //public void Player1Menu()
    //{
        //SceneManager.LoadScene("Player1Menu");
    //}

    public void Player1Mouse()
    {
        Debug.Log("button2");
        SceneManager.LoadScene(2);
    }

    public void Player1Keyboard()
    {
        Debug.Log("button3");
        SceneManager.LoadScene(3);
    }
}
