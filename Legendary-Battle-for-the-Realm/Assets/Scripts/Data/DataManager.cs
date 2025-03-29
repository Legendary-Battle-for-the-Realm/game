using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<CharacterData> allCharacters;

    private static DataManager _instance;
    public static DataManager Instance => _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(this.gameObject);

        LoadAllData();
    }

    private void LoadAllData()
    {
        LoadCharacterData();
    }

    private void LoadCharacterData()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Data/char");
        if(textAsset != null)
        {
            CharacterData[] charArray = JsonUtility.FromJson<Wrapper<CharacterData>>(WrapArray(textAsset.text)).items;
            allCharacters = new List<CharacterData>(charArray);
        }
        else
        {
            Debug.LogError("Not Found");
        }
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] items;
    }
    private string WrapArray(string json)
    {
        return "{\"items\":" + json + "}";
    }
}
