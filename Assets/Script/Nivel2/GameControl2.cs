using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl2 : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
    [SerializeField] private GameObject Puzzle2;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    [SerializeField] private GameObject CanvasLevel2;
    [SerializeField] private GameObject CanvasLevel3;

    public static bool youWin;
    
        // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0)
        {
            //youWin = true;
            winText.SetActive(true);
            ContinueButton.SetActive(true);
            Puzzle2.SetActive(false);
            

        }
    }
    public void Continue(){
        CanvasLevel2.SetActive(false);                             
        CanvasLevel3.SetActive(true);                
    }
}
