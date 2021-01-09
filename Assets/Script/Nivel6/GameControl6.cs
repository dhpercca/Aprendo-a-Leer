using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl6 : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    [SerializeField] private GameObject Puzzle1      = null;
    [SerializeField] private GameObject CanvasLevel6 = null;
    [SerializeField] private GameObject CanvasLevel2 = null;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(LetterA.locked && LetterB.locked && LetterC.locked)
        {
            Puzzle1.SetActive(false);
            winText.SetActive(true);
            ContinueButton.SetActive(true);            
        }   
    }

    public void Continue(){
        CanvasLevel6.SetActive(false);                             
        CanvasLevel2.SetActive(true);                
    }    
}