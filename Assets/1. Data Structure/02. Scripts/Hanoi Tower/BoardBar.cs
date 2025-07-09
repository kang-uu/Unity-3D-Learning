using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right }
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    void OnMouseDown()
    {
        if (!HanoiTower.isSelected) // 선택이 안된 상태일 때
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else // 선택된 상태일 때
        {
            HanoiTower.isSelected = false;
            PushDonut(HanoiTower.selectedDonut);
        }
    }

    public void PushDonut(GameObject donut)
    {
        donut.transform.position = transform.position + Vector3.up * 5f;

        barStack.Push(donut); // Stack에 GameObject를 넣는 기능
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop(); // Stack에서 GameObject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}