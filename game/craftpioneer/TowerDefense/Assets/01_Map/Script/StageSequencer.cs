using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "StageSequencer", menuName = "ScriptableObjects/StageSequencer", order = 1)]
public class StageSequencer : ScriptableObject
{

    List<Vector3> m_enemySpawnPosition = new List<Vector3>();
    public MapData mapData;

    public enum CommandType
    {
        SETSPEED,
        PUTENEMY,
        CLEAR
    }

    static readonly Dictionary<string, CommandType> commandlist = new Dictionary<string, CommandType>()
    {
        { "SETSPEED",CommandType.SETSPEED },
        { "PUTENEMY",CommandType.PUTENEMY},
        { "CLEAR",CommandType.CLEAR},
    };

    public struct StageData
    {
        public readonly float eventPos;
        public readonly CommandType command;
        public readonly int arg1;
        public readonly uint arg2;
        public StageData(float _eventpos, string _command, int _position, uint _type)//いつイベント発生するか　何するか　出現場所 敵の種類
        {
            eventPos = _eventpos;
            command = commandlist[_command];
            arg1 = _position;
            arg2 = _type;
        }
    }

    StageData[] stageDatas;
    private int stagedataidx = 0;
    [SerializeField] Enemy[] enemyPrefabs = default;

    public void Load(string filename)
    {
        m_enemySpawnPosition = mapData.EnemySpawnPosition;
        //名前から番号を引くための逆引き辞書作成
        var revarr = new Dictionary<string, uint>();
        for (uint i = 0; i < enemyPrefabs.Length; ++i)
        {
            revarr.Add(enemyPrefabs[i].name, i);
        }

        var stagecsvdata = new List<StageData>();
        var csvdata = Resources.Load<TextAsset>(filename).text;
        StringReader sr = new StringReader(csvdata);
        while (sr.Peek() != -1)
        {
            var line = sr.ReadLine();
            var cols = line.Split(',');
            if (cols.Length != 4) continue;

            stagecsvdata.Add(
                new StageData(
                float.Parse(cols[0]),
                cols[1],
                int.Parse(cols[2]),
                revarr.ContainsKey(cols[3]) ? revarr[cols[3]] : 0)
            );
        }
        stageDatas = stagecsvdata.OrderBy(item => item.eventPos).ToArray();
    }

    public void Reset()
    {
        stagedataidx = 0;
    }

    public void Step(float _stageProgressTime)//時間になると実行する
    {
        while (stagedataidx < stageDatas.Length && stageDatas[stagedataidx].eventPos <= _stageProgressTime)
        {
            switch (stageDatas[stagedataidx].command)
            {
                case CommandType.SETSPEED:
                    StageCtrl.Instance.stageSpeed = stageDatas[stagedataidx].arg1;
                    break;
                case CommandType.PUTENEMY:
                    var enmtmp = Instantiate(enemyPrefabs[stageDatas[stagedataidx].arg2], m_enemySpawnPosition[stageDatas[stagedataidx].arg1], Quaternion.identity); //変更
                    enmtmp.transform.parent = StageCtrl.Instance.enemyPool;
                    //enmtmp.transform.localPosition = new Vector3(stageDatas[stagedataidx].arg1, 0, stageDatas[stagedataidx].arg2);
                    StageCtrl.nowWaveLoad = true;
                    break;
                case CommandType.CLEAR:
                    StageCtrl.nowWaveLoad = false;
                    break;

            }
            ++stagedataidx;
        }
    }
}
