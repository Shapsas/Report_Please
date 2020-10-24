﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameModel
{
    Dictionary<DateTime, List<IScenario>> DaysWithScenarios { get; }

    event EventHandler<InspectorModeEventArgs> OnInspectorModeActivated;
    Card CurrentCard { get; set; }
    DateTime CurrentDay { get; set; }
    float CurrentPanelWidth { get; set; }
    int CurrentScenario { get; set; }
    bool Selected { get; set; }
    bool OffsetSet { get; set; }
    bool CanBeReturned { get; set; }
    bool InspectorMode { get; set; }
    Vector3 Offset { get; set; }
    RuleBookSO RuleBook { get; }
}