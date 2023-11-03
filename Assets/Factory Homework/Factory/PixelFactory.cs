using TMPro;
using UnityEngine;

public class PixelFactory : IconFactory
{
    public override Sprite GetCoinSprite()=> Resources.Load<Sprite>("Coin_Pixel");
    public override Sprite GetEnergySprite()=> Resources.Load<Sprite>("Energy_Pixel");
}
