using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateToPong : MonoBehaviour
{
    public void loadNewGamePong()
    {
        SceneManager.LoadScene("pong");
    }
}
