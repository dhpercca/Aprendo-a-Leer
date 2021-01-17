using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private GameObject Canvas      = null;
    [SerializeField] private GameObject presentation      = null;
    [SerializeField] private GameObject backgroundStart      = null;
    [SerializeField] private GameObject RegisterUser      = null;
    public Text MessageTextRegister;
    public InputField UsernameInputRegister;
    public InputField PasswordInputRegister;
    public InputField ConfirmPasswordInputRegister;
    [SerializeField] private GameObject Login             = null;
    public InputField UsernameInputLogin;
    public InputField PasswordInputLogin;
    [SerializeField] private GameObject MenuLevels      = null;
    [SerializeField] private GameObject CanvasLevel1      = null;
    [SerializeField] private GameObject CanvasLevel2      = null;
    [SerializeField] private GameObject CanvasLevel3      = null;
    [SerializeField] private GameObject CanvasLevel4      = null;
    private GameObject LinesToDestroy;
    int aleatorio;
    public GameObject[] objectsToInstantiate;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject ContinueButton;
    
    void Start()
    {
         Invoke("changeImage", 2);             
    }
    public void changeImage(){
        presentation.SetActive(false);
        backgroundStart.SetActive(true);
    }
    public void ShowLogin(){
        RegisterUser.SetActive(false);
        Login.SetActive(true);
        MessageTextRegister.text = "";
        UsernameInputRegister.text = "";
        PasswordInputRegister.text = "";
        ConfirmPasswordInputRegister.text = "";
    }

    public void ShowRegister(){
        RegisterUser.SetActive(true);
        Login.SetActive(false);
        UsernameInputLogin.text = "";
        PasswordInputLogin.text = "";
    }

    public void ShowMenuLevelsToLogin(){        
        Login.SetActive(true);
        MenuLevels.SetActive(false);        
    }

    public void ShowCanvasLevel1(){        
        Canvas.SetActive(false);        
        CanvasLevel1.SetActive(true);        
        /*for(int i = 0; i < objectsToInstantiate.Length; i++){            
            objectsToInstantiate[i].SetActive(false);
            winText.SetActive(false);
            ContinueButton.SetActive(false);            
        }*/
        aleatorio = Random.Range(0, objectsToInstantiate.Length);
        //Debug.Log(aleatorio);        
        objectsToInstantiate[aleatorio].SetActive(true);           
    }

    public void ShowCanvasLevel2(){
        Canvas.SetActive(false);
        CanvasLevel2.SetActive(true);
    }

    public void ShowCanvasLevel3(){
        Canvas.SetActive(false);
        CanvasLevel3.SetActive(true);
    }
    public void ShowCanvasLevel4(){
        Canvas.SetActive(false);
        CanvasLevel4.SetActive(true);
    } 

    public void ShowCanvasLevel1ToMenuLevels(){
        CanvasLevel1.SetActive(false);        
        Canvas.SetActive(true);
        Login.SetActive(false);
        MenuLevels.SetActive(true);        
    }

    public void ShowCanvasLevel2ToMenuLevels(){        
        CanvasLevel2.SetActive(false);        
        Canvas.SetActive(true);
        Login.SetActive(false);
        MenuLevels.SetActive(true);        
    }

    public void ShowCanvasLevel3ToMenuLevels(){        
        CanvasLevel3.SetActive(false);
        Canvas.SetActive(true);
        Login.SetActive(false);
        MenuLevels.SetActive(true);        
    }
    public void ShowCanvasLevel4ToMenuLevels(){        
        CanvasLevel4.SetActive(false);
        Canvas.SetActive(true);
        Login.SetActive(false);
        MenuLevels.SetActive(true);        
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("LineClone");
        foreach(GameObject target in gameObjects){
            GameObject.Destroy(target);
        }
    }

    public void LoadScene(string sceneToLoad){
        //SceneManager.LoadScene (sceneToLoad);
    }
}
