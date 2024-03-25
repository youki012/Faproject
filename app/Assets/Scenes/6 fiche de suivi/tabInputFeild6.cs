using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.UI;

public class TabInputField6 : MonoBehaviour
{
    public TMP_InputField dates; //0
    public TMP_InputField modeinterv; //1
    public TMP_InputField observations; //2

    public Scrollbar scrollbar;

    public int InputSelected;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputSelected++;
            if (InputSelected > 2) InputSelected = 0;
            SelectInputField();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            InputSelected--;
            if (InputSelected > 2) InputSelected = 0;
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
            {
                case 0:
                    dates.Select();
                    scrollbar.value = 1;
                    break;
                case 1:
                    modeinterv.Select();
                    scrollbar.value = 1;
                    break;
                case 2:
                    observations.Select();
                    scrollbar.value = 1;
                    break;
                

            }
        }
    }
    public void datesSelected() => InputSelected = 0;
    public void modeintervSelected() => InputSelected = 1;
    public void observationsSelected() => InputSelected = 2;
    

}
