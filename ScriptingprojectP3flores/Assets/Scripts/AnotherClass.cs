using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnothrClass : MonoBehaviour
{

    public int apples;
    public int bananas;

    public int stapler;
    public int sellotape;

    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
   
}
