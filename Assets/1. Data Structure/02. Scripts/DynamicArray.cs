using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            list1.Add(i);
        }

        // list1.Insert(5,1000); // 인덱스 5번에 1000을 삽입    

        if (list1.Contains(10)) // LIst에서 10이라는 값이 있으면 true
        {
            Debug.Log("값 10이 존재 한다");
        }
        else
        {
            Debug.Log("값 10이 존재하지 않는다");
        }
    }

}
