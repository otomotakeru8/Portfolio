using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Translation : MonoBehaviour
{
    [SerializeField]
    SettingsData settingsData;
    static SettingsData m_settingsData;

    TextAsset m_translationCsvFile;
    List<string[]> m_csvData = new List<string[]>();

    static Dictionary<string, string> m_translationDictionary = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        m_settingsData = settingsData;
        m_translationCsvFile = Resources.Load("CSV/translations") as TextAsset;
        StringReader reader = new StringReader(m_translationCsvFile.text);

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            m_csvData.Add(line.Split(','));
        }

        for (int i = 0; i < m_csvData.Count; i++)
        {
            m_translationDictionary.Add(m_csvData[i][0], m_csvData[i][m_settingsData.translationLanguages]);
        }
    }

    /// <summary>
    /// 内部名から翻訳後の文字列を返す
    /// </summary>
    /// <param name="internalName">内部名</param>
    /// <returns>翻訳後の文字列</returns>
    public static string GetTranslationText(string internalName)
    {
        if (m_settingsData.debug_doubleTextMode == true)
        {
            return m_translationDictionary[internalName] + m_translationDictionary[internalName];
        }
        return m_translationDictionary[internalName];
    }
}
