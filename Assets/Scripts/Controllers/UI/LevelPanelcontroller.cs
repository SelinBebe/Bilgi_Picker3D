using System.Collections.Generic;
using Signals;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelPanelcontroller : MonoBehaviour
{
    #region Self Variables 
    #region Serialized Variables

    [SerializeField] private List<TextMeshProUGUI> levelTexts = new List<TextMeshProUGUI>();
    [SerializeField] private List<Image> stageImage = new List<Image>();
    #endregion
    #endregion

    private void OnEnable()
    {
        SubscribeEvents();
    }

    
    private void SubscribeEvents()
    {
        UISignals.Instance.onSetNewLevelValue += OnSetNewLevelValue;
    }
    
    private void UnSubscribeEvents()
    {
        UISignals.Instance.onSetNewLevelValue -= OnSetNewLevelValue;
    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void OnSetNewLevelValue(int levelValue)
    {
        levelTexts[0].text = levelValue.ToString();
        int value = levelValue++;
        levelTexts[1].text = value.ToString();
    }
}
