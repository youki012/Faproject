using UnityEngine;
using TMPro;

public class searching : MonoBehaviour
{

    public GameObject ContentHolder;

    public GameObject[] Element;

    public GameObject SearchBar;

    public int totalElements;

    // Start is called before the first frame update
    void Start()
    {
        totalElements = ContentHolder.transform.childCount;

        Element = new GameObject[totalElements];

        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    public void Search()
    {
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchtxtlength = SearchText.Length;

        int searchElements = 0;

        foreach(GameObject ele in Element)
        {
            searchElements += 1;
            if (ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Length >= searchtxtlength)
            {
                if (SearchText.ToLower() == ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.Substring(0, searchtxtlength).ToLower()) 
                    {
                    ele.SetActive(true);
                }else { ele.SetActive(false); }
            }
        }
    }
}
