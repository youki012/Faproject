using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class TabInputField : MonoBehaviour
{
    public TMP_InputField date; //0
    public TMP_InputField nom; //1
    public TMP_InputField prenom; //2
    public TMP_InputField day; //3
    public TMP_InputField month; //4
    public TMP_InputField year; //5
    public TMP_InputField nombreenf; //6
    public TMP_InputField situationpro; //7
    public TMP_InputField adresse; //8
    public TMP_InputField num; //9
    public TMP_InputField histoiremal; //10
    public TMP_InputField medico; //11
    public TMP_InputField chirugico; //12
    public TMP_InputField psych; //13
    public TMP_InputField reeducation; //14

    public int InputSelected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            InputSelected--;
            if (InputSelected > 0) InputSelected = 14;
            SelectInputField();
        }

        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            InputSelected++;
            if (InputSelected > 14) InputSelected = 0;
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
             {
                case 0: date.Select();
                    break;
                case 1: nom.Select();
                    break;
                case 2: prenom.Select();
                    break;
                case 3: day.Select();
                    break;
                case 4: month.Select();
                    break;
                case 5: year.Select();
                    break;
                case 6: nombreenf.Select();
                    break;
                case 7: situationpro.Select();
                    break;
                case 8: adresse.Select();
                    break;
                case 9: num.Select();
                    break;
                case 10: histoiremal.Select();
                    break;
                case 11: medico.Select();
                    break;
                case 12: chirugico.Select();
                    break;
                case 13: psych.Select();
                    break;
                case 14: reeducation.Select();
                    break;

            }
        }
    }
    public void dateeSelected() => InputSelected = 0;
    public void nomeSelected() => InputSelected = 1;
    public void prenommSelected() => InputSelected = 2;
    public void dayySelected() => InputSelected = 3;
    public void monthhSelected() => InputSelected = 4;
    public void yeaaarSelected() => InputSelected = 5;
    public void nombreenfffSelected() => InputSelected = 6;
    public void sitiatioprooSelected() => InputSelected = 7;
    public void adressseSelected() => InputSelected = 8;
    public void tilifoonSelected() => InputSelected = 9;
    public void histoireeeSelected() => InputSelected = 10;
    public void midicooSelected() => InputSelected = 11;
    public void chirigikooSelected() => InputSelected = 12;
    public void psyyyccSelected() => InputSelected = 13;
    public void reediicattionSelected() => InputSelected = 14;

}
