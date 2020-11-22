using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class IconTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Touch touch;
    private Image image;


    // Update is called once per frame
    void change()
    {
        
        if(Input.touchCount == 0)
        {
            if (image)
            {
                image.enabled = false;
            }
        }

        if (Input.touchCount == 1)
        {
            if (image)
            {
                image.enabled = true;
            }
        }
    }
}
