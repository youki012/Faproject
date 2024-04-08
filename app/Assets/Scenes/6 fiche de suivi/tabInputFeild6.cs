using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.UI;
using System.Linq;
public class TabInputField6 : MonoBehaviour
{
    public TMP_InputField dates; //0
    public TMP_InputField modeinterv; //1
    public TMP_InputField observations; //2

    public Scrollbar scrollbar;

    public int InputSelected;
    int max = 200;
    int max2 = 180;
    int max3 = 400;

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
        if (dates.text.Length >= max)
        {
            if (scrollbar.value > 0f)
            {
                scrollbar.value = scrollbar.value - 0.25f;
                max = max + 100;
            }
            else
            {
                max = 200;
            }
        }
        if (modeinterv.text.Length >= max2)
        {
            if (scrollbar.value > 0f)
            {
                scrollbar.value = scrollbar.value - 0.25f;
                max2 = max2 + 90;
            }
            else
            {
                max2 = 180;
            }
        }
        if (observations.text.Length >= max3)
        {
            if (scrollbar.value > 0f)
            {
                scrollbar.value = scrollbar.value - 0.25f;
                max3 = max3 + 200;
            }
            else
            {
                max3 = 400;
            }
        }


    }
    public void datesSelected() => InputSelected = 0;
    public void modeintervSelected() => InputSelected = 1;
    public void observationsSelected() => InputSelected = 2;
    

}
