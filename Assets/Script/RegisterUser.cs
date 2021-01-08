using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUser : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public InputField ConfirmPasswordInput;
    public Button SubmitButton;
    public Text MessageTextRegister;

    // Start is called before the first frame update
    void Start()
    {        
        SubmitButton.onClick.AddListener(() => {                                     
            if(PasswordInput.text == ConfirmPasswordInput.text){
                 StartCoroutine(Main.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text));
                 UsernameInput.text = "";
                 PasswordInput.text = "";
                 ConfirmPasswordInput.text = "";
             }else{
                //Debug.Log("Las contraseñas ingresadas no son iguales.");
                MessageTextRegister.text = "Las contraseñas ingresadas no son iguales.";                
             }            
        });                   
    }
}
