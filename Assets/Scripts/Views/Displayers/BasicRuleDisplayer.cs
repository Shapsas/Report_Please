﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BasicRuleDisplayer : MonoBehaviour
{
    public TMP_Text[] rules;

    public event EventHandler<PageClosedEventArgs> OnPageBack = (sender, e) => { };

    public void DisplayRules(List<string> rulesList)
    {
        if(rules.Length == rulesList.Count)
        {
            for(int i = 0; i < rules.Length; i++)
            {
                rules[i].text = rulesList[i];
                rules[i].gameObject.GetComponent<FieldData>().SetData(rulesList[i]);
            }
        }
        gameObject.SetActive(true);
    }

    public void GoBackToHomePage()
    {
        var eventArgs = new PageClosedEventArgs();
        OnPageBack(this, eventArgs);
    }

    public void TurnOnInspectorMode()
    {
        foreach (var rule in rules)
        {
            rule.raycastTarget = false;
        }
    }

    public void TurnOffInspectorMode()
    {
        foreach(var rule in rules)
        {
            rule.raycastTarget = false;
        }
    }
}
