using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEventTemplate : ScriptableObject
{
    enum EventType
    {
        Direct,
        Major,
        Minor
    }

    #region Variables
    public GameObject tooltip;
    public string eventName;
    public string description;
    public int energyCost;
    public int experienceGain;
    public float completionTime;
    public float moneyGain;
    public float moneyCost;
    #endregion
}
