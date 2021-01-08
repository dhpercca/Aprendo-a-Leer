using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Web : MonoBehaviour
{
    public Text MessageTextLogin;
    public Text MessageTextRegister;
    [SerializeField] private GameObject MenuLevels       = null;
    [SerializeField] private GameObject MenuLogin        = null;
    void Start()
    {
        // A correct website page.
        //StartCoroutine(GetDate("https://www.example.com"));
        //StartCoroutine(GetUsers("https://www.example.com"));
        //StartCoroutine(Login("testuser3","123456"));
        //StartCoroutine(RegisterUser("testuser3","123456"));
        
    }

    IEnumerator GetDate(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/Aprendo-a-Leer/GetDate.php"))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

    IEnumerator GetUsers(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/Aprendo-a-Leer/GetUsers.php"))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

    public IEnumerator Login(string userName, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", userName);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Aprendo-a-Leer/Login.php", form))
        {
            yield return www.SendWebRequest();                        

            if (www.isNetworkError || www.isHttpError)
            {
                //Debug.Log(www.error);
                MessageTextLogin.text = www.error;
            }
            else
            {
                //Debug.Log(www.downloadHandler.text);
                MessageTextLogin.text = www.downloadHandler.text;
                if (MessageTextLogin.text == "Inicio de sesión exitoso."){
                    MessageTextLogin.text = "";                    
                    MenuLevels.SetActive(true);
                    MenuLogin.SetActive(false);
                }
            }
        }
    }

    public IEnumerator RegisterUser(string userName, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", userName);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Aprendo-a-Leer/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();                        

            if (www.isNetworkError || www.isHttpError)
            {
                //Debug.Log(www.error);
                MessageTextRegister.text = www.error;                
            }
            else
            {
                //Debug.Log(www.downloadHandler.text);
                MessageTextRegister.text = www.downloadHandler.text;
            }
        }
    }
}
