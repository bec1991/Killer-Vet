using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterTesting : MonoBehaviour
{
    public Character VetOne;
    public Character Assistant;
    
    public string nextScene;


    // Start is called before the first frame update
    void Start()
    {
        VetOne = CharacterManager.instance.GetCharacter("Vet", enableCreatedCharacterOnStart: false); 
        Assistant = CharacterManager.instance.GetCharacter("Assistant", enableCreatedCharacterOnStart: false); 
    }

    public Vector2 moveTarget;
    public float moveSpeed; 
    public bool smooth; 

    public string[] speech;
    public int[] speaker;
    int i = 0;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(i < speech.Length) {

                if(speaker[i] == 0) {
                  VetOne.Say(speech[i]);
                } else if (speaker[i] == 1) {
                  Assistant.Say(speech[i]);
                }

            } else {
                DialogSystem.instance.Close();
                SceneManager.LoadScene(nextScene);
            }
            i++;
        }

        if(Input.GetKey (KeyCode.M))
        {
            VetOne.MoveTo (moveTarget, moveSpeed, smooth);
        }
    }
}