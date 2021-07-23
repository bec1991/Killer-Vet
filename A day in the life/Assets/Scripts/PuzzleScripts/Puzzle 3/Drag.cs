/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public static event Action PuzzleDone = delegate { };

    [SerializeField]
    private Transform standPosition;

    private Vector2 initialPosition;

    private Renderer rend;

    private float deltaX, deltaY;

    private bool moveAllowed;

    private bool locked;

    void Start()
    {
        intitialPosition = transform.position;
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        moveAllowed = true;
                        rend.sortingOrder = 3;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }

                    break;

                case TouchPhase.Moved:

                    if (moveAllowed)
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY)

                            break;

                case TouchPhase.Ended:

                    moveAllowed = false;
                    rend.sortingOrder = 2;

                    if (Mathf.Abs(transform.position.x - standPosition.position.x) <= 1f &&
                        Mathf.Abs(transform.position.y - standPosition.position.y) <= 5f)
                    {
                        switch
                    }
                    }
            }

        }
    }*/
