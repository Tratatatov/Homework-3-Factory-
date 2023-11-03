using System;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;
    [SerializeField] private List<bool> _cells;
    [SerializeField] private CoinFactory _factory;
    void Awake()
    {
        for (int i = 0; i < _points.Count; i++)
        {
            _cells.Add(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        int index = GetRandomIndex();
        if (index >= 0)
        {
            CoinType randomType = (CoinType)UnityEngine.Random.Range(0,Enum.GetValues(typeof(CoinType)).Length);
            Coin newCoin = _factory.Get(randomType);
            newCoin.transform.position = _points[index].position;
            _cells[index] = true;
        }
    }
    private int GetRandomIndex()
    {
        List<int> freeCellIndexes = new List<int>();
        for (int i = 0; i < _cells.Count; i++)
        {
            if (_cells[i] == false)
            {
                freeCellIndexes.Add(i);
            }
        }
        if (freeCellIndexes.Count != 0)
        {
            return freeCellIndexes[UnityEngine.Random.Range(0, freeCellIndexes.Count)];
        }
        else
        {
            return -1;
        }
        
    }
}
