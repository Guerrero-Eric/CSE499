using UnityEngine;
using UnityEngine.SceneManagement;


public class NoteButon : MonoBehaviour
{
  public void goToNextScene()
    {
        SceneManager.LoadScene("Flashcards");
    }
}
