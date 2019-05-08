using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Properties
    public float Money { get; set; }
    public int Energy { get; set; }
    public int Level { get; set; }
    public int MaxEnergy { get; set; }
    public int Experience { get; set; }
    #endregion

    #region Methods
    void Start()
    {
        Money = 300.50f;
        Energy = 50;
        MaxEnergy = 50;
        Level = 0;
        Experience = 0;

        UIManager.Instance.UpdateMoney(Money);
        UIManager.Instance.UpdateEnergy(Energy);
        UIManager.Instance.UpdateLevel(Level + 1);
        UIManager.Instance.UpdateExperience(Experience, GameManager.levelUpXpArray[Level]);
    }
	
	void Update()
    {
		
	}

    public void ChangeMoney(float delta)
    {
        if (Money + delta < 0)
        {
            return;
        }
        else
        {
            Money += delta;
        }
        UIManager.Instance.UpdateMoney(Money);
    }

    public void ChangeEnergy(int delta)
    {
        if (Energy + delta > MaxEnergy)
        {
            Energy = MaxEnergy;
        }
        if (Energy + delta < 0)
        {
            return;
        }
        else
        {
            Energy += delta;
        }
        UIManager.Instance.UpdateEnergy(Energy);
    }

    public void GainExperience(int delta)
    {
        Experience += delta;
        if (Experience >= GameManager.levelUpXpArray[this.Level])
        {
            Experience -= GameManager.levelUpXpArray[this.Level];
            Level++;
            UIManager.Instance.UpdateLevel(Level + 1);
        }
        UIManager.Instance.UpdateExperience(Experience, GameManager.levelUpXpArray[Level]);
    }
    #endregion
}
