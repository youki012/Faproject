using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class FileDataHandler
{
    private string dataDirPath = "";
    private string datafilename = "";

    public FileDataHandler(string dataDirPath,string datafilename)
    {
        this.dataDirPath = dataDirPath;
        this.datafilename = datafilename;
    }

    public Gamedata Load()
    {
        string fullPath = Path.Combine(dataDirPath, datafilename);
        Gamedata loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }
                loadedData = JsonUtility.FromJson<Gamedata>(dataToLoad);
            }
            catch(Exception e)
            {
                Debug.LogError("Error accured when trying to load from file" + fullPath + "\n" + e);
            }
        }
        return loadedData;
    }
    public void Save(Gamedata data)
    {
        string fullPath = Path.Combine(dataDirPath,datafilename);
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            string dataToStore = JsonUtility.ToJson(data, true);

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch(Exception e)
        {
            Debug.LogError("Error accured when trying to save to file" + fullPath + "\n" + e);
        }
    }
}
