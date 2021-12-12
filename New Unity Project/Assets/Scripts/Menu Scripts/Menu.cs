using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Application.LoadLevel("StoryIntro");
    }

    // Update is called once per frame
    public void SelectLevel()
    {
        Application.LoadLevel("SelectMenu");
    }

    public void ControlMenu()
    {
        Application.LoadLevel("ControlMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
