using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class TabInputField : MonoBehaviour
{
    public TMP_InputField A; //0
    public TMP_InputField B; //1
    public TMP_InputField C; //2
    public TMP_InputField D; //3
    public TMP_InputField E; //4
    public TMP_InputField F; //5
    public TMP_InputField G; //6
    public TMP_InputField H; //7


    public int InputSelected;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputSelected++;
            if (InputSelected > 7) InputSelected = 0;
            SelectInputField();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            InputSelected--;
            if (InputSelected > 7) InputSelected = 0;
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
            {
                case 0:
                    date.Select();
                    break;
                case 1:
                    nom.Select();
                    break;
                case 2:
                    prenom.Select();
                    break;
                case 3:
                    day.Select();
                    break;
                case 4:
                    month.Select();
                    break;
                case 5:
                    year.Select();
                    break;
                case 6:
                    nombreenf.Select();
                    break;
                case 7:
                    situationpro.Select();
                    break;


            }
        }
    }
    public void AASelected() => InputSelected = 0;
    public void BBSelected() => InputSelected = 1;
    public void CCSelected() => InputSelected = 2;
    public void DDSelected() => InputSelected = 3;
    public void EESelected() => InputSelected = 4;
    public void FFSelected() => InputSelected = 5;
    public void GGSelected() => InputSelected = 6;
    public void HHSelected() => InputSelected = 7;

}
