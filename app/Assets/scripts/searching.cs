using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class searching : MonoBehaviour
{

    public GameObject ContentHolder;

    public GameObject[] Element;

    public GameObject SearchBar;

    public int totalElements;

    public Scrollbar scrollbard;

    // Start is called before the first frame update

    // Update is called once per frame
    public void Search(int scrollvalue)
    {
        totalElements = ContentHolder.transform.childCount;

        Element = new GameObject[totalElements];

        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchtxtlength = SearchText.Length;

        int searchElements = 0;

        foreach(GameObject ele in Element)
        {
            searchElements += 1;
            if (ele.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.Length >= searchtxtlength)
            {
                if (SearchText.ToLower() == ele.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.Substring(0, searchtxtlength).ToLower()) 
                    {
                    ele.SetActive(true);
                }else { ele.SetActive(false); }
            }
        }
        scrollbard.value = scrollvalue;
    }
}
