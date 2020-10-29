
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void btn_change_scene()
    {
        SceneManager.LoadScene("Flashcards");
    }

}
