using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private GameObject RegisterUser      = null;
    [SerializeField] private GameObject Login             = null;

    public void ShowLogin(){
        RegisterUser.SetActive(false);
        Login.SetActive(true);
    }

    public void ShowRegister(){
        RegisterUser.SetActive(true);
        Login.SetActive(false);
    }
}
