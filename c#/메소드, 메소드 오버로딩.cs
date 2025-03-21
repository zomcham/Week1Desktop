using UnityEngine;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} * {num2} = {result}");
    }
}