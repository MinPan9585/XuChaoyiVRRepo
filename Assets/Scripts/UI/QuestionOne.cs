using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionOne : MonoBehaviour
{
    public GameObject[] marks;
    //public int index;
    public int correctIndex;
    public GameObject piying;
    public GameObject piyingVfx;

    public void Answer(int index)
    {
        marks[index-1].SetActive(true);
        if(correctIndex == index)
        {
            //add scroe
            Instantiate(piyingVfx, piying.transform.position, Quaternion.identity);
            Destroy(piying, 2);
            Destroy(gameObject, 2);
        }
    }
}
