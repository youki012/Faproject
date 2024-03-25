using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class TabInputField2 : MonoBehaviour
{
    public TMP_InputField presentationclinique; //0
    public TMP_InputField habitudesant; //1
    public TMP_InputField projetsdupatient; //2
    public TMP_InputField attentes; //3
    public TMP_InputField objectifscourt; //4
    public TMP_InputField echeances; //5
    public TMP_InputField objectifslong; //6
    public TMP_InputField echeance; //7


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
                    presentationclinique.Select();
                    break;
                case 1:
                    habitudesant.Select();
                    break;
                case 2:
                    projetsdupatient.Select();
                    break;
                case 3:
                    attentes.Select();
                    break;
                case 4:
                    objectifscourt.Select();
                    break;
                case 5:
                    echeances.Select();
                    break;
                case 6:
                    objectifslong.Select();
                    break;
                case 7:
                    echeance.Select();
                    break;


            }
        }
    }
    public void presentationcliniqueSelected() => InputSelected = 0;
    public void habitudesantSelected() => InputSelected = 1;
    public void projetsdupatientSelected() => InputSelected = 2;
    public void attentesSelected() => InputSelected = 3;
    public void objectifscourtSelected() => InputSelected = 4;
    public void echeancesSelected() => InputSelected = 5;
    public void objectifslongSelected() => InputSelected = 6;
    public void echeanceSelected() => InputSelected = 7;

}
