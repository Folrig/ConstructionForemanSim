using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    #region Variables
    private int screenHeight;
    private int screenWidth;
    [SerializeField] private int screenOffset = 50;
    [SerializeField] private float cameraSpeed = 20.0f;
    #endregion

    #region Methods
    void Start()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
	}
	
	void Update()
    {
		if (Input.mousePosition.x > screenWidth - screenOffset)
        {
            this.transform.Translate(cameraSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.mousePosition.x < 0 + screenOffset)
        {
            this.transform.Translate(cameraSpeed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.mousePosition.y > screenHeight - screenOffset)
        {
            this.transform.Translate(0, cameraSpeed * Time.deltaTime, 0);
        }
        if (Input.mousePosition.y < 0 + screenOffset)
        {
            this.transform.Translate(0, cameraSpeed * Time.deltaTime * -1, 0);
        }
    }
    #endregion
}
