using UnityEngine;

public class EX3 : MonoBehaviour
{
    private void Start()
    {
        float width = 5;
        float height = 5;

        float targetSq = 20;

        float currentSq = width * height;

        if (currentSq > targetSq)
        {
            print($"Расчитанная: {currentSq}, Требуемая: {targetSq}, Разница: {currentSq - targetSq}");
        }
        else
        {
            print("Расчитанная площадь меньше");
        }

    }
}
