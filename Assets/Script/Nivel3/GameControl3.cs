using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl3 : MonoBehaviour
{
    public GameObject switchOn, switchOff;
    public GameObject Letter;
    public GameObject[] Syllables;
    public GameObject[] Answers;
    [SerializeField] private GameObject Pregunta1 = null;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    [SerializeField] private GameObject CanvasLevel3 = null;
    [SerializeField] private GameObject CanvasLevel4 = null;

    private string LetterToCompare = null;
    private string[] Syllable = new string[8];
    private bool[] CorrectAnswers = new bool[8];
    private bool[] YourAnswers = new bool[8];
    private int contCorrectAnswer = 0;
    // Start is called before the first frame update
    
    public void OnChangeValue(){
        bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;        
        if(onoffSwitch)
        {            
            switchOn.SetActive(true);
            switchOff.SetActive(false);            
        }
        if (!onoffSwitch)
        {
            switchOn.SetActive(false);
            switchOff.SetActive(true);        
        }                
    }
    
    public void GetAnswers(){  
        LetterToCompare = Letter.GetComponent<Text>().text;
        Debug.Log("Letra a comparar: "+LetterToCompare);              
        for(int i = 0; i < 8; i++){
            Syllable[i] = Syllables[i].GetComponent<Text>().text;            
            //Debug.Log("Opcion "+i+" "+Syllable[i]);
            if(Syllable[i][0] == LetterToCompare[0])
                CorrectAnswers[i]=true;
            else
                CorrectAnswers[i]=false;
        }
        for(int j=0; j<8; j++){ 
            YourAnswers[j] = Answers[j].GetComponent<Toggle>().isOn;
            if(YourAnswers[j] == CorrectAnswers[j])
            {
                contCorrectAnswer = contCorrectAnswer + 1; 
            }            
        }
        if(contCorrectAnswer==8){
            Debug.Log("Ganaste");
            Pregunta1.SetActive(false);            
            winText.SetActive(true);
            ContinueButton.SetActive(true);            
        }else{
            Debug.Log("Perdiste");
        }
    }

    public void Continue(){
        CanvasLevel3.SetActive(false);                             
        CanvasLevel4.SetActive(true);               
    }
   
}
