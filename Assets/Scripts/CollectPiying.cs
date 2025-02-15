using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPiying : MonoBehaviour
{
    public GameObject[] canvas;
    private void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if (other.GetComponent<PiyingFragments>()!= null)
        {
            canvas[other.GetComponent<PiyingFragments>().questionNumber].SetActive(true);
        }
    }
}
