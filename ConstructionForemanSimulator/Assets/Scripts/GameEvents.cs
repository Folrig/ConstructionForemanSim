using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    #region Variables
    public GameEventTemplate template;
    public GameObject toolTipPrefab;
    public GameObject activeTooltip;
    public string eventName;
    public string description;
    public int energyCost;
    public int experienceGain;
    public float completionTime;
    public float moneyGain;
    public float moneyCost;

    public float moveSpeed = 2.0F;
    public float timeToMove = 1.0f;
    private float moveTimer;
    private float distance;
    private bool movingUp = true;
    #endregion

    #region Methods
    void Awake()
    {
        this.eventName = template.eventName;
        this.toolTipPrefab = template.tooltip;
        this.description = template.description;
        this.energyCost = template.energyCost;
        this.experienceGain = template.experienceGain;
        this.completionTime = template.completionTime;
        this.moneyGain = template.moneyGain;
        this.moneyCost = template.moneyCost;
    }
    
    void Start()
    {
        activeTooltip = Instantiate(this.toolTipPrefab, GameObject.FindObjectOfType<Canvas>().transform);
        activeTooltip.SetActive(false);
    }

	void Update()
    {
        moveTimer += Time.deltaTime;
        if (movingUp)
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
            if (moveTimer >= timeToMove)
            {
                moveTimer = 0.0f;
                movingUp = false;
            }
        }
        if (!movingUp)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
            if (moveTimer >= timeToMove)
            {
                moveTimer = 0.0f;
                movingUp = true;
            }
        }
    }

    void OnMouseOver()
    {
        if (this.activeTooltip.activeSelf == false)
        {
            Vector3 tooltipPosition = new Vector3(this.transform.position.x + 10, this.transform.position.y + 1, this.transform.position.z + 1);
            this.activeTooltip.transform.position = Camera.main.WorldToScreenPoint(tooltipPosition);
            this.activeTooltip.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        this.activeTooltip.SetActive(false);
    }
    #endregion
}
