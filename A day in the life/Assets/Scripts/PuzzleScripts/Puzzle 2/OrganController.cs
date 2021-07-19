using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganController : MonoBehaviour
{
    [SerializeField]
    private Transform organPlace;

    private Vector2 initialPosition;

    public bool locked;

    private float leeway = 1;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - organPlace.position.x) <= leeway &&
                        Mathf.Abs(transform.position.y - organPlace.position.y) <= leeway)
        {
            transform.position = new Vector2(organPlace.position.x, organPlace.position.y);
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
