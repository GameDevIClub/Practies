using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex__1 : MonoBehaviour
{
    string line = "fAdsamffwasdgAsdfesd0vcserq fsdr e 0 ktff";

    private void Start()
    {
        int cntA = 0;
        int len = 0;
        foreach (char simvol in line)
        {
            if (simvol == '0')
            {
                Debug.Log($"���� ���������� � {len}");
                break;
            }

            if (simvol == 'a' || simvol == 'A')
            {
                cntA++;
            }

            len++;
        }
        print($"�������� 'A': {cntA}");
        Debug.Log($"����� ��������: {len}");
    }
}
