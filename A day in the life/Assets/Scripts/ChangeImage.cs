using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeImage : MonoBehaviour
{


    public Image startingImage;
    public Sprite spriteOne;
    public Sprite spriteTwo;
    public Sprite spriteThree;
    public Sprite spriteFour;
    public Sprite spriteFive;
    public Sprite spriteSix;
    public int imageNumber = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            imageNumber++;
            if (imageNumber == 1)
                startingImage.sprite = spriteOne;

            if (imageNumber == 2)
            {
                startingImage.sprite = spriteTwo;
            }
                
            if (imageNumber == 3)
            {
                startingImage.sprite = spriteThree;
            }
            
            if (imageNumber == 4)
            {
              startingImage.sprite = spriteFour;
                    
            }
           
            if (imageNumber == 5)
            {
                  startingImage.sprite = spriteFive;
                  

            }
             if (imageNumber == 6)
            {
              startingImage.sprite = spriteSix;
              QuitGame();
                    
            }


        }
    }

     public void QuitGame()
    {
        Application.Quit();
    }
}

    
