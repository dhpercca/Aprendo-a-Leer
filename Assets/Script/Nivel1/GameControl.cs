using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    [SerializeField] private GameObject Puzzle1      = null;
    [SerializeField] private GameObject CanvasLevel1 = null;
    [SerializeField] private GameObject CanvasLevel2 = null;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(LetraA.locked && LetraB.locked && LetraC.locked)
        {
            Puzzle1.SetActive(false);
            winText.SetActive(true);
            ContinueButton.SetActive(true);            
        }   
    }

    public void Continue(){
        CanvasLevel1.SetActive(false);                             
        CanvasLevel2.SetActive(true);                
    }    
}
