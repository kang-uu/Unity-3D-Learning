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

        // list1.Insert(5,1000); // �ε��� 5���� 1000�� ����    

        if (list1.Contains(10)) // LIst���� 10�̶�� ���� ������ true
        {
            Debug.Log("�� 10�� ���� �Ѵ�");
        }
        else
        {
            Debug.Log("�� 10�� �������� �ʴ´�");
        }
    }

}
