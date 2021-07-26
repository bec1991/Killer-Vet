using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OrganController : MonoBehaviour
{
    //public GameObject Pieces;

    public static OrganController instance;

    [SerializeField]
    private Transform organPlace;
    public GameObject pooper;

    private Vector2 initialPosition;

    public bool locked;

    private float leeway = 1;

    public UnityEvent Wazfaz;

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
            //When locked go parent.GetComponent < whatever the script is > ().updateLocked
            //GameObject Pieces = GameObject.FindGameObjectWithTag("Pieces");
            //var Pieces = GameObject.Find("Pieces");
            //Pieces.GetComponent<OrganManager>().updateLocked;
            Wazfaz.Invoke();
            print("bruh");
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
