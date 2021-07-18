using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{

    
    DialogSystem dialog; 

    void Start()
    {    
        dialog = DialogSystem.instance;

    }

    public string[] s = new string[]
    {
        "This is a test:Bec",
        "Hope this works!",
        "Hell yeah it works"

        // Scene 2 "There's a pet here. The owner's crying in the back. We're not sure how much longer it has.: Assistant"
    // Scene 3 "Is there anything you could do?: Assistant"
    // Scene 4 "Please you have to save her.: Client"
    // Scene 5 "We need her blood work, X Rays a catheter and monitoring STAT!: Vet"
    // Scene 6 "Assistant, how are the other clients going?: Vet"
    // Scene 7 "Well your first appointment was at 9 but we had to move that to 9:20. The client seems pissed. She said if you're going to be disrespectful with her time, she can always leave and put up a scathing review on FaceBook.:Assistant"
    // Scene 10 "There have also been 15 drop off appointments. So I don't think lunch will be an option today.:Assistant"
    // Scene 11 "They have a urinary obstruction. It will have to be removed immediately or else there is a very real chance that your pet will die.:Vet"
    // Scene 12 "But I can't afford to!: Client"
    // Scene 12 "This is life threatening! Otherwise your only option will be euthanasia.: Vet"
    // Scene 12 "You're going to make me kill my pet just because I'm poor? Why the fuck are you a vet if you don't even give a shit about animals?: Client"
    // Scene 13 "If I can't do this, I can't handle the guilt of letting something else die.: Vet"
    // Scene 15 "I don't know what I'm going to do... I've still got 30+ years of this. God knows if I'll even be able to retire.: Vet"
    // Scene 16 "IDIOT! We can't afford after hour surgery! Not to mention that you adjusted the bill to make it more affordable. I hope you know your pay will be docked!: Vet Clinic Manager"
    // Scene 17 "When a soul is suffering and there is no treatment, it's not only acceptable but compassionate to euthanise.: Not sure"
    // Scene 18 "Vet Death Facts.: Not sure"
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
