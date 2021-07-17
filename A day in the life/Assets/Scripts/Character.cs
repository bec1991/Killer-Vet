using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Character : MonoBehaviour
{
    public string characterName;
    // the root is the container for all images related to the character in the scene
    //the root object.
    [HideInInspector]public RectTransform root;

    public bool isMultiLayerCharacter{get {return renderers.renderer == null;}}

    //create new character
    public Character (string _name)
    {
        CharacterManager cm = CharacterManager.instance;
        // locates the character Prefab
        GameObject prefab = Resources.Load("Characters/Character["+ _name +"]") as GameObject;
        // spawn an instance of the prefab directly on the character panel.
        GameObject ob = Instantiate (prefab, cm.characterPanel);
    
        root = ob.GetComponent<RectTransform> ();
        characterName = _name; 

        renderers.renderer = ob.GetComponentInChildren<RawImage>();
        if(isMultiLayerCharacter)
        {   
            // these are what I called them in the prefab
            renderers.bodyRenderer = ob.transform.Find("bodyLayer").GetComponent<Image> ();
            renderers.expressionRenderer = ob.transform.Find("expressionLayer").GetComponent<Image> ();
        }
        //get the renderer/s
    }

    class Renderers
    {
        //used as the only image for a single layer character
        public RawImage renderer;

        //sprites use images
        //the body render for a multi layer character
        public Image bodyRenderer;

        //the expression renderer for a multi layer character
        public Image expressionRenderer;
    }

    Renderers renderers = new Renderers(); 
}
