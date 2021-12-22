﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class sceneswitcher : MonoBehaviour,IPointerClickHandler
{
    public int sceneindex = 0;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        //Debug.Log("current scene name =" + scene.name + "and scene index = " + scene.buildIndex);

        SceneManager.LoadScene(++sceneindex);
    }
}
