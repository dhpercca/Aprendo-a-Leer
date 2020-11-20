using System;
using System.Collections;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public void CreateUser(string userName, string pass, Action<string> response){
        StartCoroutine( CO_CreateUser( userName, pass, response));
    }

    private IEnumerator CO_CreateUser(string userName, string pass, Action<string> response){
        WWWForm form = new WWWForm();
        form.AddField("userName", userName);
        form.AddField("pass", pass);

        WWW w = new WWW("http://localhost/aprendo-a-leer/createUser.php", form);

        yield return w;

        response( JsonUtility.FromJson<Response>(w.text) );

    }
}

[Serializable]
public class Response{
    public bool done = false;
    public string message  ="";
}
