using UnityEngine;
using UnityEngine.LightTransport;

public class StudyString : MonoBehaviour
{
    public string str1 = " Hello ";

    public string[] str2 = new string[3] {"Hello","Unity","World"};

    public void Start()
    {
        Debug.Log(str1[0]); // H
        Debug.Log(str1[2]); // l

        Debug.Log(str2[0]); // Hello
        Debug.Log(str2[2]); // World

        Debug.Log(str1.Length); // ���ڿ��� ���� : 5
        Debug.Log(str1.Trim()); // �յ� ���� ����
        Debug.Log(str1.Trim('l')); // ���� 'l' ����

    }
}
