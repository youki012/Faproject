using UnityEngine;
using TMPro;

public class search3 : MonoBehaviour
{

    public GameObject ContentHolder;

    public GameObject[] Element;

    public GameObject SearchBar;

    public int totalElements;

    public GameObject[] mains;

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

        foreach (GameObject ele in Element)
        {
            searchElements += 1;
            if (ele.transform.GetComponent<TextMeshProUGUI>().text.Length >= searchtxtlength)
            {
                if (SearchText.ToLower() == ele.transform.GetComponent<TextMeshProUGUI>().text.Substring(0, searchtxtlength).ToLower())
                {
                    ele.SetActive(true);
                }
                else { ele.SetActive(false); }
            }
        }
    }
    public int numberofmains;
    int x = 0;
    private void Update()
    {
        while (x<numberofmains){
            mains[x].SetActive(true);
            x++;
            
     }
        x = 0;
    }
}