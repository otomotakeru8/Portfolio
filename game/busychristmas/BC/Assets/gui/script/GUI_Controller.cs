using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*-------------------------------------------------------------

	演出を制御するには、AnimState に値を代入してください。
	0=待機 / 1= スタート演出開始 / 2=ゲームセット演出開始
	スタート時に1を代入するだけで,勝手にゲームセットします。

 --------------------------------------------------------------*/

public class GUI_Controller : MonoBehaviour
{
	[Space(10)]
	[Header("CONFIG")]
	public ushort StageTimeLimit;
	[Space(10)]
	public float DelayTimeDispStart;		// AnimState が1(開始)になった時,スタート演出開始までの時間(sec)
	public float HoldTimeHideStart;			// スタート演出開始後,表示が消えるまでのホールド時間(sec)
	public float DelayTimeDispEnd;			// AnimState が2(終了)になった時,ゲームセット演出開始までの時間(sec)
	public float HoldTimeHideEnd;			// ゲームセット演出開始後,表示が消えるまでのホールド時間(sec)
	public float HoldTimeUntilTransScene;	// ゲームセット後,シーン遷移するまでの時間(sec)
											// トランジションエフェクトなどがある場合は,その所要時間も含めて設定してください。
	public string SceneAfterTrans;			// ゲームセット後に遷移するシーン名
	
	[Space(10)]
	[Header("OBJECTS")]
	public GameObject GUI_DECO_TIMER;
	public GameObject GUI_FONT_TIMER;
	public GameObject GUI_FONT_START;
	public GameObject GUI_FONT_END;
	public Animation ANIM_FONT;
	public Text TEXT_TIMER;
	float TIMER;
	
	public static short AnimState;
	ushort SceneState;
	
	
	void Start()
	{
		GUI_DECO_TIMER.SetActive(true);
		GUI_FONT_TIMER.SetActive(true);
		GUI_FONT_START.SetActive(false);
		GUI_FONT_END.SetActive(false);
		
		AnimState = 1;
		SceneState = 0;
		TEXT_TIMER.text = StageTimeLimit.ToString();
		TIMER = StageTimeLimit;
	}

	void Update()
	{
		// デバッグ用
		if (Input.GetKey (KeyCode.Alpha0))
			AnimState = 0;
		if (Input.GetKey (KeyCode.Alpha1))
			AnimState = 1;
		if (Input.GetKey (KeyCode.Alpha2))
			AnimState = 2;
		if (Input.GetKey (KeyCode.Alpha9))	// 使わないでください
			AnimState = -1;
		
		
		// 処理中ではない時,スタート演出開始
		if (AnimState != -1 && AnimState == 1)
		{
			AnimState = -1;
			
			if(SceneState != 0)
				SceneState = 0;
			
			GUI_FONT_START.SetActive(true);
			
			Invoke("DispStart", DelayTimeDispStart);
			Invoke("HideStart", 0.5f + HoldTimeHideStart);
			
			AnimState = 0;
		}
		// 処理中ではない時,ゲームセット演出開始
		if (AnimState != -1 && AnimState == 2)
		{
			AnimState = -1;
			SceneState = 0;
			GUI_FONT_END.SetActive(true);
			
			Invoke("DispEnd", DelayTimeDispEnd);
			Invoke("HideEnd", 0.5f + HoldTimeHideEnd);
			
			AnimState = 0;
		}
		
		if(SceneState == 1)
		{
			TIMER -= Time.deltaTime;
			TEXT_TIMER.text = String.Format("{0:0}", TIMER);
		}
		
		if(SceneState == 1 && TIMER < 0.0f)
		{
			SceneState = 0;
			AnimState = 2;
		}
	}
	
	
	void DispStart()
	{
		ANIM_FONT.Play ("start0");
	}
	
	void HideStart()
	{
		ANIM_FONT.Play ("start1");
		SceneState = 1;
	}
	
	void DispEnd()
	{
		ANIM_FONT.Play ("end0");
	}
	
	void HideEnd()
	{
		ANIM_FONT.Play ("end1");
		Invoke("TransScene", 0.25f + HoldTimeUntilTransScene);
	}
	
	void TransScene()
	{
		SceneManager.LoadScene(SceneAfterTrans);
	}
}
