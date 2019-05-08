using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    #region Variables
    [SerializeField] private TextMeshProUGUI moneyLabel;
    [SerializeField] private TextMeshProUGUI energyLabel;
    [SerializeField] private TextMeshProUGUI experienceLabel;
    [SerializeField] private TextMeshProUGUI levelLabel;
    #endregion

    #region Properties
    #endregion

    #region Methods
    public void UpdateMoney(float money)
    {
        string moneyString = string.Format("{0:N2}", money);
        moneyLabel.text = "$" + moneyString;
    }

    public void UpdateEnergy(int energy)
    {
        energyLabel.text = "" + energy;
    }

    public void UpdateExperience(int currentXP, int levelXP)
    {
        experienceLabel.text = "" + currentXP + " / " + levelXP;
    }

    public void UpdateLevel(int level)
    {
        levelLabel.text = "Level - " + level;
    }
    #endregion
}
