using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

/*Gestione salvataggio livello*/
public class SaveLoad : MonoBehaviour
{
    private int sceneId;
    private string sceneName;


    // Update is called once per frame
    public void Save()
    {
        BinaryFormatter binary = new BinaryFormatter();
        FileStream fStream = File.Create(Application.persistentDataPath + "saveFile.octo");

        SaveManager saver = new SaveManager();
        sceneName = SceneManager.GetActiveScene().name;

        saver.levelSaved = sceneName;

        binary.Serialize(fStream, saver);
        fStream.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "saveFile.octo"))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Open(Application.persistentDataPath + "saveFile.octo", FileMode.Open);
            SaveManager saver = (SaveManager)(binary.Deserialize(fStream));
            fStream.Close();


            this.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene(saver.levelSaved);
        }
    }
}

[Serializable]
class SaveManager
{
    public string levelSaved;
}
