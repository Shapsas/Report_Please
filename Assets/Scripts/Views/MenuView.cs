﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuView : MonoBehaviour, IMenuView
{
    [SerializeField]
    private GameObject titleScreen;
    [SerializeField]
    private GameObject mainMenuScreen;

    public event EventHandler<StoryButtonPressedEventArgs> OnStoryButtonPressed = (sender, e) => { };

    public void Play()
    {
        if(titleScreen.activeInHierarchy)
        {
            titleScreen.SetActive(false);
            mainMenuScreen.SetActive(true);
        }
    }

    public void PlayStory()
    {
        var eventArgs = new StoryButtonPressedEventArgs();
        OnStoryButtonPressed(this, eventArgs);
    }
}
