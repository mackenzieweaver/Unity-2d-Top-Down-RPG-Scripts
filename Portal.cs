﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{
    public string[] sceneNames;
    protected override void OnCollilde(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            GameManager.instance.SaveState();
            // Teleport the player
            string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}
