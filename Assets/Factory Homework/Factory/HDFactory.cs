using UnityEngine;

public class HDFactory : IconFactory
{
    public override Sprite GetCoinSprite() => Resources.Load<Sprite>("Coin_HD");
    public override Sprite GetEnergySprite() => Resources.Load<Sprite>("Energy_HD");
}
