using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionOne : MonoBehaviour
{
    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public void AnswerOne()
    {
        mark1.SetActive(true);
    }

    public void AnswerTwo()
    {
        mark2.SetActive(true);
    }

    public void AnswerThree()
    {
        mark3.SetActive(true);
    }

    public void AnswerFour()
    {
        mark4.SetActive(true);
    }
}
