using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string stroka = "Lorem ipsum dolor sit amet, consectetur Adipiscing0 elit. Mauris gravida Aliquam ante nec luctus.";
        int count = 0, countA = 0;

        foreach (char c in stroka)
        {
            count++;

            if (c == '0')
            {
                Debug.Log($"� ����������� ���� ������ 0, ��� ������ {count - 1}.");
                break;
            }

            if (c.ToString().ToLower() == "a")
            {
                countA++;
            }
        }

        Debug.Log($"� ����������� {count} ��������");
        Debug.Log($"� ����������� {countA} �������� a");

    }

}
