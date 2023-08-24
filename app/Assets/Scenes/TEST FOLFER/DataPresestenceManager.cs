using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DataPresestenceManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] private string fileName;

    private Gamedata gamedata;
    public static DataPresestenceManager instance { get; private set; }
    private List<IDataPresistence> dataPresistencesobjects;
    private FileDataHandler dataHandler;
     
    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogError("found more than one thing");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPresistencesobjects = FindAllDataPresistenceObjects();
        load();
    }



    public void newone()
    {

        this.gamedata = new Gamedata();
    }

   
    public void load()
    {
        this.gamedata = dataHandler.Load();

        if(this.gamedata == null)
        {
            Debug.LogError("no data found doing default");
            newone();
        }
        foreach (IDataPresistence dataPresistenceObj in dataPresistencesobjects)
        {
            dataPresistenceObj.LoadData(gamedata);
        }
        Debug.LogError("loaded x = " + gamedata.x);
    }

    public void save()
    {
        foreach (IDataPresistence dataPresistenceObj in dataPresistencesobjects)
        {
            dataPresistenceObj.SaveData(ref gamedata);
        }
        Debug.LogError("saved x = " + gamedata.x);
        dataHandler.Save(gamedata);
    }
    private void OnApplicationQuit()
    {
        save();
    }
    private List<IDataPresistence> FindAllDataPresistenceObjects()
    {
        IEnumerable<IDataPresistence> dataPresistencesobjects = FindObjectsOfType<MonoBehaviour> ()
    .OfType<IDataPresistence>();
        return new List<IDataPresistence>(dataPresistencesobjects);
    }
}
