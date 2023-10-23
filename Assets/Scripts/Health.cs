using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    [SerializeField] Image HealthImage;
    [SerializeField] int DecreaceCount = 2;
    [SerializeField] int HealthCount = 100;

    // Update is called once per frame
    void Update()
    {
        if (HealthCount < 100)
        {
            HealthCount++;
        }

        UpdateUI();
    }

    public int GetHealth()
    {
        return HealthCount;
    }

    public void DecreaseHealth()
    {
        if(HealthCount <= 0) 
        {
            return;
        }
        HealthCount -= DecreaceCount;
    }

    private void UpdateUI()
    {
        HealthImage.fillAmount = HealthCount / 100f;
    }
}
