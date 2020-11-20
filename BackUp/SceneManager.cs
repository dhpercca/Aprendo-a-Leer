﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private GameObject m_registerUI      = null;
    [SerializeField] private GameObject m_loginUI         = null;
    [SerializeField] private Text       m_text            = null;
    [SerializeField] private InputField m_userNameInput   = null;
    [SerializeField] private InputField m_password        = null;
    [SerializeField] private InputField m_reEnterPassword = null;
    
    private NetworkManager m_networkManager = null;

    private void Awake(){
        m_networkManger = GameObject.FindObjectOfType<NetworkManager>();
    }

    public void SubmitLogin(){
        if(m_userNameInput.text == "" || m_password.text == "" || m_reEnterPassword.text == ""){
            m_text.text = "Por favor llena todos los campos";
            return;
        }

        if(m_password.text == m_reEnterPassword.text){
            m_text.text = "Procesando...";

            m_networkManager.CreateUser(m_userNameInput.text, m_password.text, delegate(Response response){
                m_text.text = response.message;
            });
        }
        else{
            m_text.text = "Las contraseñas no son iguales por favor verificar";
        }
    }

    public void ShowLogin(){
        m_registerUI.SetActive(false);
        m_loginUI.SetActive(true);
    }

    public void ShowRegister(){
        m_registerUI.SetActive(true);
        m_loginUI.SetActive(false);
    }
}
