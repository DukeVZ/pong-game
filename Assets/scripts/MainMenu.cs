using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void loadNewGame()
    {
        SceneManager.LoadScene("paddel");
    }

    public void singelPlayer()
    {
        SceneManager.LoadScene("onePlayer");
    }
}
