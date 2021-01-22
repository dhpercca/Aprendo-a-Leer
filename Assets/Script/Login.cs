using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField userNameInput;
    public InputField passwordInput;
    public Button loginButton;
    public GameObject startInstructionSound;    

    // Start is called before the first frame update
    void Start()
    {        
       loginButton.onClick.AddListener(() => {           
           StartCoroutine(Main.Instance.Web.Login(userNameInput.text, passwordInput.text)); 
           userNameInput.text = "";
           passwordInput.text = "";               
       });
       Instantiate(startInstructionSound);
    }
}
