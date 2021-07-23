using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageChecker : MonoBehaviour
{
    public float piece1;

    public float piece2;

    public float piece3;

    public float piece4;

    public GameObject[] cagesPlaced;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("yeet");
    }

}
