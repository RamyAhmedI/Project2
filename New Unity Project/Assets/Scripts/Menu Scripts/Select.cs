using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back()
    {
        Application.LoadLevel("Menu");
    }

    // Update is called once per frame
    public void Level1()
    {
        UnityEngine.Application.LoadLevel("Level1");
    }

    public void Level2()
    {
        Application.LoadLevel("Level2");
    }

    public void Level3()
    {
        Application.LoadLevel("Level3");
    }
}
