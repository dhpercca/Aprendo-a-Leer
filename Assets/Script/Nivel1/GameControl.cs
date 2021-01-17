using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    [SerializeField] private GameObject Puzzle1=null;

    [SerializeField] private GameObject CanvasLevel1 = null;
    [SerializeField] private GameObject CanvasLevel2 = null;
    public GameObject[] puzzles;
    int aleatorio;
    int[] activePuzzle = new int[12];    
    int puzzleCounterDisabled;
    public GameObject winSound;
    //int controladorAleatorio=0;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        //numero de puzzles para generar aleatoriamente sin que se repitan        
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
        if(A.locked && B.locked && C.locked)
        {   
            if(activePuzzle[0] == 0){
                randomPuzzle(0);                
            }                                                                      
        } 
        if(D.locked && E.locked && F.locked)
        {                                    
            if(activePuzzle[1] == 0){
                randomPuzzle(1);
            }           
        } 
        if(G.locked && H.locked && I.locked)
        {                        
            if(activePuzzle[2] == 0){
                randomPuzzle(2);
            }            
        } 
        if(J.locked && K.locked && L.locked)
        {                        
            if(activePuzzle[3] == 0){
                randomPuzzle(3);
            }            
        } 
        if(M.locked && N.locked && O.locked)
        {            
            if(activePuzzle[4] == 0){
                randomPuzzle(4);
            }            
        } 
        if(P.locked && Q.locked && R.locked)
        {            
            if(activePuzzle[5] == 0){
                randomPuzzle(5);
            }            
        } 
        if(S.locked && T.locked && U.locked)
        {            
            if(activePuzzle[6] == 0){
                randomPuzzle(6);
            }            
        } 
        if(V.locked && W.locked && X.locked)
        {            
            if(activePuzzle[7] == 0){
                randomPuzzle(7);
            }            
        } 
        if(Y.locked && Z.locked)
        {            
            if(activePuzzle[8] == 0){
                randomPuzzle(8);
            }            
        } 
        if(Uno.locked && Dos.locked && Tres.locked)
        {            
            if(activePuzzle[9] == 0){
                randomPuzzle(9);
            }            
        } 
        if(Cuatro.locked && Cinco.locked && Seis.locked)
        {            
            if(activePuzzle[10] == 0){
                randomPuzzle(10);
            }            
        } 
        if(Siete.locked && Ocho.locked && Nueve.locked)
        {            
            if(activePuzzle[11] == 0){
                randomPuzzle(11);
            }           
        } 
    }

    public void randomPuzzle(int numberPuzzle){
        activePuzzle[numberPuzzle] = 1; //0: activo - 1: inactivo
        puzzles[numberPuzzle].SetActive(false); //-1 puzzle activo
        puzzleCounterDisabled = 0;
        for(int i = 0; i < puzzles.Length; i++){
            if(activePuzzle[i] == 0)
                i = 12;
            else
                puzzleCounterDisabled++;
        }
        do
        {            
            aleatorio = Random.Range(0, puzzles.Length);                    
        }while(activePuzzle[aleatorio] == 1 && puzzleCounterDisabled < 12); //filtrar puzzles inactivos                 
        if(puzzleCounterDisabled < 12)
            puzzles[aleatorio].SetActive(true);
        else{            
            winText.SetActive(true);
            ContinueButton.SetActive(true);
            Instantiate(winSound);
        }

    }
    public void Continue(){
        winText.SetActive(false);
        ContinueButton.SetActive(false);
        CanvasLevel1.SetActive(false);                             
        CanvasLevel2.SetActive(true);                
    }  
}
