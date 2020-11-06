using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class List : MonoBehaviour
{   

    [Serializable]
    public struct Muscle
    {
        public string Name;
        public string Origin;
        public string Insertion;
        public string Action;
        public string Nerve_innervation;
        public Sprite Icon;
    }
    [SerializeField] Muscle[] allMuscle;

    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        int N = allMuscle.Length;

        for(int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = allMuscle[i].Name;
            g.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = allMuscle[i].Origin;
            g.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = allMuscle[i].Insertion;
            g.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = allMuscle[i].Action;
            g.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = allMuscle[i].Nerve_innervation;  
            g.transform.GetChild(5).GetComponent<Image>().sprite = allMuscle[i].Icon;

        }
        Destroy(buttonTemplate);
    }

}
