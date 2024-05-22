using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject staminaGlobe;

    public void DropStamina()
    {
        int totalStaminaGlobes = 3; // Jumlah staminaGlobe yang ingin dijatuhkan
        int instantiatedGlobes = 0;

        while (instantiatedGlobes < totalStaminaGlobes)
        {
            Instantiate(staminaGlobe, transform.position, Quaternion.identity);
            instantiatedGlobes++;
        }
    }
}
