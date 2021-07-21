using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterTesting : MonoBehaviour
{
    public Character VetOne;
    public Character Assistant;
    public Character Pamela;
    public Character Jane;
    public Character VetTwo;

    public Character VetThree;
    public Character VetFour;
    public Character VetFive;
    public Character VetSix;
    public Character AssistantTwo;

    public string nextScene;


    // Start is called before the first frame update
    void Start()
    {
        VetOne = CharacterManager.instance.GetCharacter("Vet", enableCreatedCharacterOnStart: false); 
        VetSix = CharacterManager.instance.GetCharacter("Vet", enableCreatedCharacterOnStart: false); 
        VetTwo = CharacterManager.instance.GetCharacter(".Vet", enableCreatedCharacterOnStart: false); 
        VetThree = CharacterManager.instance.GetCharacter("Vet...", enableCreatedCharacterOnStart: false); 
        VetFour = CharacterManager.instance.GetCharacter("Vet..", enableCreatedCharacterOnStart: false); 
        VetFive = CharacterManager.instance.GetCharacter("Vet,", enableCreatedCharacterOnStart: false); 
        Assistant = CharacterManager.instance.GetCharacter("Assistant", enableCreatedCharacterOnStart: false); 
        AssistantTwo = CharacterManager.instance.GetCharacter("Assistant.", enableCreatedCharacterOnStart: false); 
        Pamela = CharacterManager.instance.GetCharacter("Pamela", enableCreatedCharacterOnStart: false); 
        Jane = CharacterManager.instance.GetCharacter("Jane", enableCreatedCharacterOnStart: false); 
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
            if(i < speech.Length) 
            {

                if(speaker[i] == 0) 
                {
                  VetOne.Say(speech[i]);
                } 

                else if (speaker[i] == 1) 
                {
                  Assistant.Say(speech[i]);
                }

                else if(speaker[i] == 2) 
                {
                    Pamela.Say(speech[i]);
                }

                 else if(speaker[i] == 3) 
                {
                    VetTwo.Say(speech[i]);
                } 
                else if (speaker[i] == 4) 
                {
                  AssistantTwo.Say(speech[i]);
                } 
                else if (speaker[i] == 5) 
                {
                  VetThree.Say(speech[i]);
                }
                else if (speaker[i] == 6) 
                {
                  VetFour.Say(speech[i]);
                }
                else if (speaker[i] == 7) 
                {
                  Jane.Say(speech[i]);
                }
                else if (speaker[i] == 8) 
                {
                  VetFive.Say(speech[i]);
                }
                else if (speaker[i] == 9) 
                {
                  VetSix.Say(speech[i]);
                }
                else 
                {
                    DialogSystem.instance.Close();
                    SceneManager.LoadScene(nextScene);
                }
            }
            i++;
        }

        if(Input.GetKey (KeyCode.M))
        {
            VetOne.MoveTo (moveTarget, moveSpeed, smooth);
        }
    }
}