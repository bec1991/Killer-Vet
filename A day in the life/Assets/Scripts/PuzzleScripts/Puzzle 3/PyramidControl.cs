using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PyramidControl : MonoBehaviour
{
    /*public static int slotsOccupied;

    [SerializeField]
    private Transform[] rings;

    [SerializeField]
    private GameObject winSign;

    [SerializeField]
    private GameObject wrongSign;

    // Start is called before the first frame update
    private void Start()
    {
        PetStack.PuzzleDone += CheckResults;
        slotsOccupied = 0;
        winSign.SetActive(false);
        wrongSign.SetActive(false);
    }

    public void CheckResults() 
    {
        //Finished x axis pos -1.495414
        if (rings[0].position.y == 4.2f &&
            rings[1].position.y == 2.72f &&
            rings[2].position.y == 0.56f &&
            rings[3].position.y == -1.84f)
        {
            winSign.SetActive(true);
        }
        else 
        {
            wrongSign.SetActive(true);
            Invoke("ReloadGame", 1f);
        }
    }

    private void ReloadGame() 
    {
        Drag.PuzzleDone -= CheckResults;
        SceneManager.LoadScene("Puzzle 3");
    }*/
}
