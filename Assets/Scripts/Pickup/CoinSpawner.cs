using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject goldCoin;

    public void DropCoins()
    {
        int totalGoldCoins = 10; // Jumlah koin emas yang ingin dijatuhkan
        int instantiatedCoins = 0;

        while (instantiatedCoins < totalGoldCoins)
        {
            Instantiate(goldCoin, transform.position, Quaternion.identity);
            instantiatedCoins++;
        }
    }
}
