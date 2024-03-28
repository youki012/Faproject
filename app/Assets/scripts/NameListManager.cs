using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NameListManager : MonoBehaviour
{
    public GameObject canvas;
    public Text displayText;
    private List<database> nameList = new List<database>();

    public void AddName()
    {
        string name = "jon";


        // Create a new Person object and add it to the list
        database Database = new database();
        Database.Name = name;
        

        nameList.Add(Database);
        // Saving the list
        string json = JsonUtility.ToJson(nameList);
        PlayerPrefs.SetString("NameListData", json);
        PlayerPrefs.Save();

        
        
        // Clear the input fields after adding the person
        // Optionally, you can update the displayText to show the updated list
    }
    public void Load()
    {
        string savedData = PlayerPrefs.GetString("NameListData");
        nameList = JsonUtility.FromJson<List<database>>(savedData);
        
        

        displayText.text = savedData;
    }
}
public class database
{
    // Start is called before the first frame update
    public string Name;
    public int age;
}
