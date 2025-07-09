using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right }
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    void OnMouseDown()
    {
        if (!HanoiTower.isSelected) // ������ �ȵ� ������ ��
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // ���õ� ������ ��
        {
            HanoiTower.isSelected = false;
            PushDonut(HanoiTower.selectedDonut);
        }
    }

    public void PushDonut(GameObject donut)
    {
        donut.transform.position = transform.position + Vector3.up * 5f;

        barStack.Push(donut); // Stack�� GameObject�� �ִ� ���
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack���� GameObject�� ������ ���

        return donut; // ���� ������ ��ȯ
    }
}