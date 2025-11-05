using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX5 : MonoBehaviour
{
    [SerializeField] private int dimensione = 10;
    [SerializeField] private int minimo = 0;
    [SerializeField] private int massimo = 20;

    //Genera un array casuale 
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

    //Stampa gli elementi di un array
    void StampaArray(int[] arr, string nome = "Array")
    {
        if (arr == null)
        {
            Debug.Log(nome + ": array nullo.");
            return;
        }

        if (arr.Length == 0)
        {
            Debug.Log(nome + ": array vuoto.");
            return;
        }

        string testo = nome + " -> ";
        for (int i = 0; i < arr.Length; i++)
        {
            testo += arr[i] + " ";
        }

        Debug.Log(testo);
    }

    //Cambia la dimensione di un array
    int[] CambiaDimensioneArray(int[] arr, int nuovaDim)
    {
        if (nuovaDim < 0)
        {
            Debug.LogWarning("La nuova dimensione non può essere negativa. Uso 0.");
            nuovaDim = 0;
        }

        if (arr == null)
        {
            Debug.LogWarning("Array nullo: ne creo uno nuovo di zeri.");
            return new int[nuovaDim];
        }

        int vecchiaDim = arr.Length;

        //Se la dimensione è uguale, restituisco lo stesso array
        if (nuovaDim == vecchiaDim)
        {
            Debug.Log("Dimensione invariata: restituisco l'array originale.");
            return arr;
        }

        //Creo il nuovo array
        int[] nuovo = new int[nuovaDim];

        //Determino quanti elementi copiare
        int elementiDaCopiare;

        if (nuovaDim < vecchiaDim)
        {
            //Se il nuovo array è più piccolo, copio solo i primi 'nuovaDim' elementi
            elementiDaCopiare = nuovaDim;
        }
        else
        {
            //Se il nuovo array è più grande, copio tutti gli elementi vecchi
            elementiDaCopiare = vecchiaDim;
        }

        //Copia degli elementi
        for (int i = 0; i < elementiDaCopiare; i++)
        {
            nuovo[i] = arr[i];
        }

        //I nuovi spazi (se presenti) restano 0 automaticamente

        return nuovo;
    }

    void Start()
    {
        //Genera array iniziale
        int[] originale = GeneraArray(dimensione, minimo, massimo);
        StampaArray(originale, "Array originale");

        //Caso 1: rimpicciolisco
        int nuovaDim1 = originale.Length - 3;
        int[] ridotto = CambiaDimensioneArray(originale, nuovaDim1);
        StampaArray(ridotto, "Array rimpicciolito");

        //Caso 3: ingrandisco
        int nuovaDim2 = originale.Length + 4;
        int[] ingrandito = CambiaDimensioneArray(originale, nuovaDim2);
        StampaArray(ingrandito, "Array ingrandito");

        //Caso 3: stessa dimensione
        int[] stesso = CambiaDimensioneArray(originale, originale.Length);
        StampaArray(stesso, "Array stessa dimensione");

    }

   
    void Update()
    {
        
    }
}
