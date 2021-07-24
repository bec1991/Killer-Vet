using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dialog : MonoBehaviour
{

    
    DialogSystem dialog; 

    void Start()
    {    
        dialog = DialogSystem.instance;

    }

    public string[] s = new string[]
    {
       

      
    };


    

    int index = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!dialog.isSpeaking || dialog.isWaitingForUserInput)
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

        dialog.Say(speech, speaker);
    }

}
