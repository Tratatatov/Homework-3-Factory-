using System;
using UnityEngine;
[Serializable]
public class CoinConfig
{
    [SerializeField, Range(-2, 10)] private int _score;
    [SerializeField] private Coin _prefab;

    public int Score => _score;
    public Coin Prefab => _prefab;

}
