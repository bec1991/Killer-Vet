using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{

    //realised I spelt this wrong but we cant go back now
    DialogSystem dialogue; 

    void Start()
    {    
        dialogue = DialogSystem.instance;

    }

    public string[] s = new string[]
    {
        "This is a test:Bec",
        "Hope this works!",
        "Hell yeah it works"
    };

    

    int index = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
            {
                if(index>= s.Length)
                {
                    return;
                }

                Say(s[index]);
                index++;
            } 

        }
    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech, speaker);
    }

}
