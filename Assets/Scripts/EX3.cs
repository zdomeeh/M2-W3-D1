using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    [SerializeField] private int dimensione = 10;  
    [SerializeField] private int minimo = 0;      
    [SerializeField] private int massimo = 100;    

    public int[] GeneraArray(int dimensione, int minimo, int massimo)
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

    public void StampaArray(int[] arr)
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

    public int TrovaMinimo(int[] arr)
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

    public int TrovaMassimo(int[] arr)
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
        }

    }
    void Update()
    {
        
    }
}
