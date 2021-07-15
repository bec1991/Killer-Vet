using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    // adding a static so when we need the dialog system in any othere script we locate it by instance
    public static DialogSystem instance;

    public ELEMENTS elements;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () 
    {
        
    }

    // Say something and show it on the speech box.

    public void Say(string speech, string speaker = "")
    {
        StopSpeaking();

        speaking = StartCoroutine(Speaking(speech, false, speaker));
    }

    
    /// Say something to be added to what is already on the speech box.
    public void SayAdd(string speech, string speaker = "")
    {
        StopSpeaking();

        speechText.text = targetSpeech;

        speaking = StartCoroutine(Speaking(speech, true, speaker));
    }


    // seperate function that stops the active session and sets the corouutine to null again
    public void StopSpeaking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }
        
    public bool isSpeaking {get{return speaking != null;}}
    [HideInInspector] public bool isWaitingForUserInput = false;

    public string targetSpeech = "";

    
    Coroutine speaking = null;
    IEnumerator Speaking(string speech, bool additive, string speaker = "")
    {
        speechPanel.SetActive(true);
        targetSpeech = speech;

        if (!additive)
            speechText.text = "";
        else
            targetSpeech = speechText.text + targetSpeech;

        speakerNameText.text = DetermineSpeaker(speaker);//temporary

        isWaitingForUserInput = false;

        while(speechText.text != targetSpeech) // last session of speach should be cleared and build the new one untill its finished
        {
            speechText.text += targetSpeech[speechText.text.Length];
            yield return new WaitForEndOfFrame();
        }

        //text finished
        isWaitingForUserInput = true;
        while(isWaitingForUserInput)
            yield return new WaitForEndOfFrame();

        StopSpeaking();
    }

    string DetermineSpeaker(string s)
    {
        string retVal = speakerNameText.text;//default return is the current name
        if (s != speakerNameText.text && s != "")
            retVal = (s.ToLower().Contains("narrator")) ? "" : s;

        return retVal;
    }

    [System.Serializable]
    public class ELEMENTS
    {
        
        /// The main panel containing all dialogue related elements on the UI
        
        public GameObject speechPanel;
        public Text speakerNameText;
        public Text speechText;
    }
    public GameObject speechPanel {get{return elements.speechPanel;}}
    public Text speakerNameText {get{return elements.speakerNameText;}}
    public Text speechText {get{return elements.speechText;}}
}