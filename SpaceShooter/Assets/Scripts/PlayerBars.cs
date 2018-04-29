using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBars : MonoBehaviour
{
    public RectTransform energyAmountFill;

    private PlayerControl playerControl  = new PlayerControl();

    void Update()
    {
        EnergyBar(playerControl.GetEnergyAmount());    
    }

    void EnergyBar(float energyAmount)
    {
        energyAmountFill.localScale = new Vector3(energyAmount, 1f, 1f);
    }
}
