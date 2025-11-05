using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    [SerializeField] private int dimensione = 10;
    [SerializeField] private int minimo = 0;
    [SerializeField] private int massimo = 100;

    // --- Trova e stampa i due numeri più piccoli ---
    void TrovaMinimi2(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            Debug.LogWarning("TrovaMinimi2: array nullo o con meno di 2 elementi.");
            return;
        }

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];

            if (n < min1)
            {
                min2 = min1;
                min1 = n;
            }
            else if (n < min2)
            {
                min2 = n;
            }
        }

        Debug.Log($"I due numeri più piccoli sono: {min1} e {min2}");
    }

    // --- Trova e stampa i due numeri più grandi ---
    void TrovaMassimi2(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            Debug.LogWarning("TrovaMassimi2: array nullo o con meno di 2 elementi.");
            return;
        }

        int max1 = int.MinValue;
        int max2 = int.MinValue;

        // Ora anche qui usiamo il for
        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];

            if (n > max1)
            {
                max2 = max1;
                max1 = n;
            }
            else if (n > max2)
            {
                max2 = n;
            }
        }

        Debug.Log($"I due numeri più grandi sono: {max1} e {max2}");
    }

    int[] GeneraArray(int dimensione, int minimo, int massimo)
    {
        if (dimensione <= 0)
        {
            Debug.LogWarning("La dimensione deve essere positiva!");
            return new int[0];
        }

        if (minimo > massimo)
        {
            Debug.LogWarning("Il minimo non può essere maggiore del massimo!");
            return new int[0];
        }

        int[] arr = new int[dimensione];

        for (int i = 0; i < dimensione; i++)
        {

            arr[i] = Random.Range(minimo, massimo + 1);
        }

        return arr;
    }

    void StampaArray(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Debug.Log("Array vuoto o nullo.");
            return;
        }

        string output = "Array: ";
        for (int i = 0; i < arr.Length; i++)
        {
            output += arr[i] + " ";
        }
        Debug.Log(output);
    }
   
    int TrovaMinimo(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            Debug.LogWarning("Array nullo o vuoto.");

        int minimo = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minimo)
                minimo = arr[i];
        }
        return minimo;
    }

    int TrovaMassimo(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            Debug.LogWarning("Array nullo o vuoto.");

        int massimo = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > massimo)
                massimo = arr[i];
        }
        return massimo;
    }
    void Start()
    {
        int[] mioArray = GeneraArray(dimensione, minimo, massimo);

        StampaArray(mioArray);

        if (mioArray.Length > 0)
        {
            int min = TrovaMinimo(mioArray);
            int max = TrovaMassimo(mioArray);

            Debug.Log($"Valore minimo trovato: {min}");
            Debug.Log($"Valore massimo trovato: {max}");

            // test funzioni nuove
            TrovaMinimi2(mioArray);
            TrovaMassimi2(mioArray);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
