using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public virtual class IconFactory
{

    protected Sprite CoinSprite;
    protected Sprite EnergySprite;
    public Sprite GetCointIcon() {
        return CoinSprite;
    }
    public Sprite GetEnergyIcon()
    {
        return EnergySprite;
    }
}
