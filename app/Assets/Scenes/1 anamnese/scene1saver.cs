using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using System.Linq;
using System;


public class scene1saver : MonoBehaviour
{
    public TMP_InputField date;

    public gender gender;

    public TMP_InputField nom;   public TMP_InputField prenom;
    public TMP_InputField dd;    public TMP_InputField mm;    public TMP_InputField yy;

    public TMP_Dropdown situationfamil;

    public TMP_InputField nombreDenfant;

    public TMP_InputField situationPro;

    public TMP_InputField adresse;

    public TMP_InputField telephon;

    public TMP_InputField histoirMaladie;

    public TMP_InputField medicaaux;

    public TMP_InputField chirur;

    public TMP_InputField psychiat;

    public TMP_InputField reeduction;
    void Start()
    {
        if (File.Exists(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/nom.text")) { 
        Load();
    }
    }
    public void Save()
    {
               
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/gender.text", gender.f.ToString());

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/date.text", date.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/nom.text", nom.text);    
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/prenom.text", prenom.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/dd.text", dd.text);
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/mm.text", mm.text); 
        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/yy.text", yy.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/nomenfant.text", nombreDenfant.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/situationfam.text", situationfamil.value.ToString());

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/situationpro.text", situationPro.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/adresse.text", adresse.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/telephon.text", telephon.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/histoirMaladie.text", histoirMaladie.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/medicaux.text", medicaaux.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/chirur.text", chirur.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/psyc.text", psychiat.text);

        File.WriteAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/reeduc.text", reeduction.text);

        Debug.Log("saved!");
    }


    public void Load()
    {
        gender.females.isOn = bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/gender.text"));
        gender.males.isOn = !bool.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/gender.text"));

        date.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/date.text");

        nom.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/nom.text");  
        prenom.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/prenom.text");

        dd.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/dd.text"); 
        mm.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/mm.text");
        yy.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/yy.text");

        nombreDenfant.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/nomenfant.text");

        situationfamil.value = int.Parse(File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/situationfam.text"));

        situationPro.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/situationpro.text");

        adresse.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/adresse.text");

        telephon.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/telephon.text");

        histoirMaladie.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/histoirMaladie.text");

        medicaaux.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/medicaux.text");

        chirur.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/chirur.text");

        psychiat.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/psyc.text");

        reeduction.text = File.ReadAllText(Application.dataPath + "/patients" + "/" + File.ReadAllText(Application.dataPath + "/currentpatient.text") + "/InformationGeneral" + "/reeduc.text");

        Debug.Log("loaded!");
    }

}
