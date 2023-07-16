using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string user;
    public int actualScore;
    public RecordData recordData = new RecordData();

    public static GameManager Instance;

    #region GameObject overrides 
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);        
    }

    // Update is called once per frame
    void Update()
    {

        



    }
    #endregion

    public void SaveRecord()
    {
        RecordData data = new RecordData();
        data = recordData;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadRecord()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            recordData = JsonUtility.FromJson<RecordData>(json);            

        }
    }

}


[System.Serializable]
public class RecordData
{
    public string user = "none";
    public int record = 0;

}
