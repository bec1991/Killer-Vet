using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTesting : MonoBehaviour
{
    public Character Vet;


    // Start is called before the first frame update
    void Start()
    {
        Vet = CharacterManager.instance.GetCharacter("Vet", enableCreatedCharacterOnStart: false); 
    }

    public Vector2 moveTarget;
    public float moveSpeed; 
    public bool smooth; 

    public string[] speech;
    int i = 0;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))  
        {
            if(i < speech.Length)
        
                Vet.Say(speech [i]);
            
            else 
                DialogSystem.instance.Close();
                i++;
        }  

        if(Input.GetKey (KeyCode.M))
        {
            Vet.MoveTo (moveTarget, moveSpeed, smooth);
        }
    }
}
