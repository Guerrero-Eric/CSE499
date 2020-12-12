using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Web : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // A correct website page.
        StartCoroutine(GetLibrary("http://localhost/BAMBackend/GetLibrary.php"));
        
        //StartCoroutine(Login("http://localhost/BAMBackend/Login.php"));
        //StartCoroutine(GetItemsIDs("http://localhost/BAMBackend/GetItemsIDs.php"));
        
        // A non-existing page.
        StartCoroutine(GetLibrary("https://error.html"));
    }

    IEnumerator GetLibrary(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
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
}
