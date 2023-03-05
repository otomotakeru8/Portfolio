using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCtrl : MonoBehaviour
{
    [SerializeField] public Transform enemyPool = default;
    [SerializeField] private StageSequencer sequencer = default;

    public float stageSpeed = 1; 
    float stageProgressTime = 0;

    private static StageCtrl instance;
    public static StageCtrl Instance { get => instance; }

    public static bool nowWaveLoad = false;

    [SerializeField] public string fail;

    private void Awake()
    {
        instance = this.GetComponent<StageCtrl>();
    }

    // Start is called before the first frame update
    void Start()
    {
        sequencer.Load(fail);
        sequencer.Reset(); 
        stageProgressTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //stage event progress
        sequencer.Step(stageProgressTime); 
        stageProgressTime += Time.deltaTime;
    }

    public void WaveStart(string m_failname)
    {
        sequencer.Load(m_failname);
        sequencer.Reset();
        stageProgressTime = 0;
    }
}
