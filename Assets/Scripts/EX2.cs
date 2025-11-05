using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    [SerializeField] private int number, numberMultipleX, numberMultipleY;
    bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    bool isMultipleOf(int baseNumber, int multiple)
    {
        if (multiple % baseNumber == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void Start()
    {
        bool evenResult = IsEven(number);
        if (evenResult == true)
        {
            Debug.Log("Il numero " + number + " è pari!");
        }
        else
        {
            Debug.Log("Il numero " + number + " è dispari!");
        }

        bool multipleResult = isMultipleOf(numberMultipleX, numberMultipleY);
        if (multipleResult == true)
        {
            Debug.Log(numberMultipleY + " è multiplo di " + numberMultipleX);
        }
        else
        {
            Debug.Log(numberMultipleY + " non è multiplo di " + numberMultipleX);
        }
    }
    void Update()
    {

    }
}

