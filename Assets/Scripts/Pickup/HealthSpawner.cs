using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    [SerializeField] private GameObject healthGlobe;

    public void DropHealth()
    {
        int totalHealthGlobes = 5; // Jumlah healthGlobe yang ingin dijatuhkan
        int instantiatedGlobes = 0;

        while (instantiatedGlobes < totalHealthGlobes)
        {
            Instantiate(healthGlobe, transform.position, Quaternion.identity);
            instantiatedGlobes++;
        }
    }
}
