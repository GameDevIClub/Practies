using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_3 : MonoBehaviour
{
    void Start()
    {
        int Length = 13;
        int Width = 15;
        int Square_1 = Length * Width;
        int Square_2 = 200;
        if (Square_2 > Square_1)
        {
            Debug.Log($"�������� ������� {Square_2}");
            Debug.Log($"����������� ������� {Square_1}");
            Debug.Log($"������� �������� {Square_2 - Square_1}");
        }
    }
}
