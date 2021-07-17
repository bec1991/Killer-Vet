using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


  // this script is responcible for adding and maintaining characters in the scene
public class CharacterManager : MonoBehaviour
{
    
    public static CharacterManager instance; 

    //All characters must be attached to the character panel
    public RectTransform characterPanel;


    // a list of all characters currently in scene
    public List<Character> characters = new List<Character>();


    //easy look up for characters
    public Dictionary<string, int> characterDictionary = new Dictionary<string, int>();




    void Awake()
    {
        instance = this;
    }

    //try to get character name provided from the character list.
    public Character GetCharacter(string, characterName, bool createCharacterIfDoesNotExist = true)
    {   

        //search dictionry to find the character quickly if it is already in our scene
        int index = -1;
        if(characterDictionary.TryGetValue (characterName, out index))
        {
            return characters [index];
        }
        else if(createCharacterIfDoesNotExist)
        {
            return CreateCharacter (characterName);
        }

        return null;
    }   


    //creates character
    //returns the character

    public Character CreateCharacter(string characterName);
    {
        Character newCharacter = new Character (characterName);
        characterDictionary.Add (characterName, characters.Count);
        characters.Add(newCharacter);

        return newCharacter;
    }

    
}
