using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Character
{   
    // the root is the container for all images related to the character in the scene
    //the root object.
    [HideInInspector]public RectTransform root;

    DialogSystem dialog; 

    public string characterName;


    public bool isMultiLayerCharacter{get{ return renderers.renderer == null;}}

    public bool enabled{get{ return root.gameObject.activeInHierarchy;} set{root.gameObject.SetActive(value);}}
    

    //the space between the anchors of the character. Define how much space a chatacter takes up on the canvas

    public Vector2 anchorPadding{get{return root.anchorMax - root.anchorMin;}}

    public void Say(string speech, bool add = false)
    {
        if(!enabled)
        {
            enabled =true;
        }

        if(!add)
        {
            dialog.Say(speech, characterName);
        }
        else
        {
            dialog.SayAdd(speech, characterName);
        }

    }
    Vector2 targetPosition;
    Coroutine moving;
    bool isMoving{get{ return moving != null;}}


    public void MoveTo(Vector2 Target, float speed, bool smooth  = true)
    {   
        //stop moving if we're moving
        StopMoving();

        //start moving coroutine
        moving = CharacterManager.instance.StartCoroutine(Moving(Target, speed, smooth));
    }

    public void StopMoving()
    {
        if(isMoving)
        {
            CharacterManager.instance.StopCoroutine (moving);

        }
        moving = null;
    }

    IEnumerator Moving(Vector2 target, float speed, bool smooth)
    {
        targetPosition = target;


        Vector2 padding = anchorPadding;
        float maxX = 1f - padding.x;
        float maxY = 1f - padding.y;

        Vector2 minAnchorTarget = new Vector2(maxX * targetPosition.x, maxY * targetPosition.y);
        speed *= Time.deltaTime;


        //move untill we reach target position
        while(root.anchorMin != minAnchorTarget)
        {
            root.anchorMin = (!smooth) ? Vector2.MoveTowards(root.anchorMin, minAnchorTarget, speed) : Vector2.Lerp(root.anchorMin, minAnchorTarget, speed);
            root.anchorMax = root.anchorMin + padding;

            yield return new WaitForEndOfFrame ();
        }
        StopMoving();
        //
    }
    



    //create new character
    public Character (string _name, bool enableOnStart = true)
    {
        CharacterManager cm = CharacterManager.instance;


        // locates the character Prefab
        GameObject prefab = Resources.Load("Characters/Character["+ _name +"]") as GameObject;


        // spawn an instance of the prefab directly on the character panel.
        GameObject ob = GameObject.Instantiate (prefab, cm.characterPanel);
    

        root = ob.GetComponent<RectTransform> ();
        characterName = _name; 

        renderers.renderer = ob.GetComponentInChildren<RawImage>();
        if(isMultiLayerCharacter)
        {   
            // these are what I called them in the prefab
            renderers.bodyRenderer = ob.transform.Find("bodyLayer").GetComponent<Image> ();
            renderers.expressionRenderer = ob.transform.Find("expressionLayer").GetComponent<Image> ();
        }

        dialog = DialogSystem.instance;
        
        enabled = enableOnStart;

        //get the renderer/s
    }
    [System.Serializable]
    public class Renderers
    {
        //used as the only image for a single layer character
        public RawImage renderer;

        //sprites use images
        //the body render for a multi layer character
        public Image bodyRenderer;

        //the expression renderer for a multi layer character
        public Image expressionRenderer;
    }

    public Renderers renderers = new Renderers(); 
}
