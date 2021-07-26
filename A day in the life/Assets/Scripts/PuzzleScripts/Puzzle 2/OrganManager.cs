using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrganManager : MonoBehaviour
{
    public GameObject pieces;

    public static OrganManager instance;

    int lockedPieces;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

        // Update is called once per frame
    public void Update()
    {
        //UpdateLocked();
    }

    /*Function updateLocked {
    Increase total by 1
    Check if it has reached 4
    If yes, next scene
    */

    public void UpdateLocked() 
    {
        lockedPieces += 1;
        print(lockedPieces);
        if (lockedPieces == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            print("yeetus wheetus");
            
        }
    }
}
