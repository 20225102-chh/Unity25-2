using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGauge;
    
    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    
}
