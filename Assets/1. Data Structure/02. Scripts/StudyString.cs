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

        Debug.Log(str1.Length); // 문자열의 길이 : 5
        Debug.Log(str1.Trim()); // 앞뒤 공백 제거
        Debug.Log(str1.Trim('l')); // 문자 'l' 제거

    }
}
