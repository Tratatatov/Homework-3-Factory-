using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int _score;
    public void Initialize(int score)
    {
        _score = score;
    }
}
