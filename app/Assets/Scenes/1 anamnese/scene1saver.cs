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

    public void Save()
    {
        
        Directory.CreateDirectory(Application.dataPath + "/infopage");

        File.WriteAllText(Application.streamingAssetsPath + "gender.text", gender.f.ToString());

        File.WriteAllText(Application.streamingAssetsPath + "nom.text", nom.text);     File.WriteAllText(Application.streamingAssetsPath + "prenom.text", prenom.text);

        File.WriteAllText(Application.streamingAssetsPath + "dd.text", dd.text); File.WriteAllText(Application.streamingAssetsPath + "mm.text", mm.text); File.WriteAllText(Application.streamingAssetsPath + "yy.text", yy.text);

        File.WriteAllText(Application.streamingAssetsPath + "nomenfant.text", nombreDenfant.text);

        File.WriteAllText(Application.streamingAssetsPath + "situationfam.text", situationfamil.value.ToString());

        File.WriteAllText(Application.streamingAssetsPath + "situationpro.text", situationPro.text);

        File.WriteAllText(Application.streamingAssetsPath + "adresse.text", adresse.text);

        File.WriteAllText(Application.streamingAssetsPath + "telephon.text", telephon.text);

        File.WriteAllText(Application.streamingAssetsPath + "histoirMaladie.text", histoirMaladie.text);

        File.WriteAllText(Application.streamingAssetsPath + "medicaux.text", medicaaux.text);

        File.WriteAllText(Application.streamingAssetsPath + "chirur.text", chirur.text);

        File.WriteAllText(Application.streamingAssetsPath + "psyc.text", psychiat.text);

        File.WriteAllText(Application.streamingAssetsPath + "reeduc.text", reeduction.text);

        Debug.Log("saved!");
    }


    public void Load()
    {
        gender.females.isOn = bool.Parse(File.ReadAllText(Application.streamingAssetsPath + "gender.text")); gender.males.isOn = !bool.Parse(File.ReadAllText(Application.streamingAssetsPath + "gender.text"));

        nom.text = File.ReadAllText(Application.streamingAssetsPath + "nom.text");     prenom.text = File.ReadAllText(Application.streamingAssetsPath + "prenom.text");

        dd.text = File.ReadAllText(Application.streamingAssetsPath + "dd.text"); mm.text = File.ReadAllText(Application.streamingAssetsPath + "mm.text"); yy.text = File.ReadAllText(Application.streamingAssetsPath + "yy.text");

        nombreDenfant.text = File.ReadAllText(Application.streamingAssetsPath + "nomenfant.text");

        situationfamil.value = int.Parse(File.ReadAllText(Application.streamingAssetsPath + "situationfam.text"));

        situationPro.text = File.ReadAllText(Application.streamingAssetsPath + "situationpro.text");

        adresse.text = File.ReadAllText(Application.streamingAssetsPath + "adresse.text");

        telephon.text = File.ReadAllText(Application.streamingAssetsPath + "telephon.text");

        histoirMaladie.text = File.ReadAllText(Application.streamingAssetsPath + "histoirMaladie.text");

        medicaaux.text = File.ReadAllText(Application.streamingAssetsPath + "medicaux.text");

        chirur.text = File.ReadAllText(Application.streamingAssetsPath + "chirur.text");

        psychiat.text = File.ReadAllText(Application.streamingAssetsPath + "psyc.text");

        reeduction.text = File.ReadAllText(Application.streamingAssetsPath + "reeduc.text");

        Debug.Log("loaded!");
    }

}
