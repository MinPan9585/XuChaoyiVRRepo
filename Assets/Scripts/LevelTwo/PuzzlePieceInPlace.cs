using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceInPlace : MonoBehaviour
{

    public Transform otherPiece;



    private void Update()
    {
        if(Vector3.Distance(transform.position, otherPiece.position) <= 0.2f)
        {
            if (!otherPiece.GetComponent<PuzzleFragment>().isBeingDragged)
            {
                this.GetComponent<MeshRenderer>().enabled = true;
                Destroy(otherPiece.gameObject);
            }
        }
    }
}
