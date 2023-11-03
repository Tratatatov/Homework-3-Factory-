using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CoinFactory")]
public class CoinFactory: ScriptableObject
{
    [SerializeField] CoinConfig _bad, _good,_veryGood;
    public Coin Get(CoinType type)
    {
        CoinConfig coinConfig = GetConfig(type);
        Coin instance = Instantiate(coinConfig.Prefab);
        instance.Initialize(coinConfig.Score);
        return instance;
    }
    private CoinConfig GetConfig(CoinType type)
    {
        switch (type)
        {
            case CoinType.Bad:
                return _bad;   
            case CoinType.Good:
                return _good;
            case CoinType.VeryGood:
                return (_veryGood);
            default:
                throw new ArgumentException("Выбран неверный тип");
        }
    }

}
