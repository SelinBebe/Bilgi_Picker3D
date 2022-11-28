using System;
using System.Collections;
using System.Collections.Generic;
using Signals;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnavle()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onLevelSuccessful += OnLevelSuccessful;
        CoreGameSignals.Instance.onLevelFailed += OnLevelFailed;
        CoreGameSignals.Instance.onReset += OnReset;
    }

    private void UnSubscribeEvents()
    {
        CoreGameSignals.Instance.onLevelSuccessful -= OnLevelSuccessful;
        CoreGameSignals.Instance.onLevelFailed -= OnLevelFailed;
        CoreGameSignals.Instance.onReset -= OnReset;
    }

    private void OnDisable()
    {
        UnSubscribeEvents;
    }

    private void OnLevelSuccessful()
    {
        
    }

    public NextLevel()
    {
        
    }

    public RestartLevel()
    {
        
    }

    public Play()
    {
        
    }

    private void onReset()
    {
        CoreUISignals.Instance.onCloseAlPanels?.Invoke();
        
    }
    
}
