using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    #region Variables
    private Player player;
    public static int[] levelUpXpArray = new int[10] { 5, 10, 20, 35, 50, 75, 100, 150, 200, 300 };
    #endregion

    #region Properties
    #endregion

    #region Methods
    void Start()
    {
        player = FindObjectOfType<Player>();
	}

	void Update()
    {
		
	}
    #endregion
}
