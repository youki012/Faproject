using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class adder : MonoBehaviour , IDataPresistence
{
    public int x = 0;
  
    public TextMeshProUGUI text;

    public TMP_InputField inputer;

    // Start is called before the first frame update

    public void LoadData(Gamedata data) 
    {
        this.x = data.x;
        inputer.text = data.inputed;
    }

    public void SaveData(ref Gamedata data)
    {
        data.x = this.x;
        data.inputed = inputer.text;
    }
    // Update is called once per frame
    public void clicker()
    {
        x++;
        
        
        
}
    void Update()
    {
        
        text.text = x.ToString();
    }
}
