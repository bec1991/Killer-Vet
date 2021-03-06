using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField]
    private Transform brainPlace;

    private Vector2 initialPosition;

    private float deltaY;

    private float deltaX;

    public static bool locked;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - brainPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - brainPlace.position.y) <= 0.5f)
        {
            transform.position = new Vector2(brainPlace.position.x, brainPlace.position.y);
            locked = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

    private void OnMouseDrag()
    {
        if (locked == false) 
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 1);
        }
    }
}
