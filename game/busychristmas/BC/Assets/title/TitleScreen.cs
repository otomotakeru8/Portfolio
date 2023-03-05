using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
	// オブジェクト =========================================================== 変数: オブジェクト
	GameObject beginPar;
	GameObject beginButtonPas;
	GameObject beginButtonAct;
	
	GameObject configPar;
	GameObject configButtonPas;
	GameObject configButtonAct;
	GameObject exitPar;
	GameObject exitButtonPas;
	GameObject exitButtonAct;
	
	GameObject kl0Wrapper;
	public static GameObject pc1Wrapper;
	public static GameObject pc2Wrapper;
	GameObject checkPcColision1F;
	GameObject checkPcColision2F;
	GameObject camera1F;
	GameObject camera2F;

	GameObject fadePanel;
	GameObject f1Canvas;
	GameObject f2Canvas;
	GameObject pc1Header; // "プレイヤー1のスキン"
	GameObject pc2Header; // "プレイヤー2のスキン"
	GameObject redRibbon; // 上の背景の赤帯
	
	
	// スキン ================================================================= 変数: スキン
	GameObject pc1skin0;
	GameObject pc1skin1;
	GameObject pc1skin2;
	GameObject pc1skin3;
	
	GameObject pc2skin0;
	GameObject pc2skin1;
	GameObject pc2skin2;
	GameObject pc2skin3;
	
	
	// サウンド =============================================================== 変数: サウンド
	AudioSource TitleBgm;
	
	
	
	// ロッカールーム ========================================================= 変数: ロッカールーム
	public static bool isLockerUsing;
	public static ushort NowSkinSelection;
	
	GameObject lk0skin0;
	GameObject lk0skin1;
	GameObject lk0skin2;
	GameObject lk0skin3;

	GameObject cursor0;
	GameObject cursor1;
	GameObject cursor2;
	GameObject cursor3;

	public static ushort SelectionCursor;
	
	
	// アニメーション ========================================================= 変数: アニメーション
	Animation fadeIn;
	Animation fadeOut;
	Animation f1CamIn;
	Animation f2CamOut;
	
	
	[Header("プレイヤの設定")]
	public Vector3 Pc1SpawnPos;
	public float Pc1InitZRot;
	public Vector3 Pc2SpawnPos;
	public float Pc2InitZRot;
	
	[Header("遷移先シーンの設定")]
	public string MainSceneName;
	public string ConfigSceneName;
	
	[Header("サウンドの設定")]
	public ushort BgmPlayDelay;
	
	[Header("デバッグ用変数")]
	public static ushort	Pc1Skin;
	public static ushort	Pc2Skin;
	public static short		MenuSelection;
	
	
	public static byte ScreenState;

	public AudioClip sfxBack;
	public AudioClip sfxCursor;
	AudioSource audioSource;

	bool a;

	void Start() // *********************************************************** 関数: Start
	{
		beginPar = GameObject.Find("begin");
		beginButtonPas = GameObject.Find("begin_button_passive");
		beginButtonAct = GameObject.Find("begin_button_active");
		configPar = GameObject.Find("config");
		configButtonPas = GameObject.Find("config_button_passive");
		//configButtonAct = GameObject.Find("config_button_active");
		exitPar = GameObject.Find("exit");
		exitButtonPas = GameObject.Find("exit_button_passive");
		exitButtonAct = GameObject.Find("exit_button_active");
		
		f1Canvas = GameObject.Find("1FCanvas");
		f2Canvas = GameObject.Find("2FCanvas");
		redRibbon = GameObject.Find("RedRibbon");
		
		kl0Wrapper = GameObject.Find("LockerSkinWrapper");
		pc1Wrapper = GameObject.Find("Pc1Wrapper");
		pc2Wrapper = GameObject.Find("Pc2Wrapper");

		camera1F = GameObject.Find("MainCamera");
		camera2F = GameObject.Find("LockerCamera");

		cursor0 = GameObject.Find("Cursor0");
		cursor1 = GameObject.Find("Cursor1");
		cursor2 = GameObject.Find("Cursor2");
		cursor3 = GameObject.Find("Cursor3");

		// スキン
		pc1skin0 = GameObject.Find("pc1skin0");
		pc1skin1 = GameObject.Find("pc1skin1");
		pc1skin2 = GameObject.Find("pc1skin2");
		pc1skin3 = GameObject.Find("pc1skin3");
		
		pc2skin0 = GameObject.Find("pc2skin0");
		pc2skin1 = GameObject.Find("pc2skin1");
		pc2skin2 = GameObject.Find("pc2skin2");
		pc2skin3 = GameObject.Find("pc2skin3");
		
		lk0skin0 = GameObject.Find("lk0skin0");
		lk0skin1 = GameObject.Find("lk0skin1");
		lk0skin2 = GameObject.Find("lk0skin2");
		lk0skin3 = GameObject.Find("lk0skin3");
		// スキンおわり
		
		fadePanel = GameObject.Find("FadePanel");

		TitleBgm = GetComponent<AudioSource>();
		audioSource = GetComponent<AudioSource>();

		Pc1Skin = 0;
		Pc2Skin = 1;
		MenuSelection = -1;
		ScreenState = 0;

		SelectionCursor = 0;

		Invoke("PlayBgm", BgmPlayDelay);

		a = true;
	}

	void AT()
    {
		a = true;
    }
	
	void Update() //*********************************************************** 関数: Update
	{
		//--------------------------------------------------------------------- 関数: メニュー
		// UPDATE: メインメニュー関連
		//----------------------------------------
		
		switch(MenuSelection)
		{
			case 0:
				beginButtonPas.SetActive(false);
				beginButtonAct.SetActive(true);
				configButtonPas.SetActive(true);
				//configButtonAct.SetActive(false);
				exitButtonPas.SetActive(true);
				exitButtonAct.SetActive(false);
				break;
			
			case 1:
				beginButtonPas.SetActive(true);
				beginButtonAct.SetActive(false);
				configButtonPas.SetActive(false);
				//configButtonAct.SetActive(true);
				exitButtonPas.SetActive(true);
				exitButtonAct.SetActive(false);
				break;
			
			case 2:
				beginButtonPas.SetActive(true);
				beginButtonAct.SetActive(false);
				configButtonPas.SetActive(true);
				//configButtonAct.SetActive(false);
				exitButtonPas.SetActive(false);
				exitButtonAct.SetActive(true);
				break;
			
			default:
				beginButtonPas.SetActive(true);
				beginButtonAct.SetActive(false);
				configButtonPas.SetActive(true);
				//configButtonAct.SetActive(false);
				exitButtonPas.SetActive(true);
				exitButtonAct.SetActive(false);
				break;
		}
		
		
		// シーン移動
		
		if(ScreenState == 0 && MenuSelection == 0 && (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown("joystick 1 button 0") || Input.GetKeyDown("joystick 2 button 0")))
		{
			TitleBgm.Stop();
			SceneManager.LoadScene(MainSceneName);
		}
		else if(ScreenState == 0 && MenuSelection == 1 && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown("joystick 1 button 0") || Input.GetKeyDown("joystick 2 button 0")))
		{
			// TitleBgm.Stop();
			SceneManager.LoadScene(ConfigSceneName);
		}
		else if(ScreenState == 0 && MenuSelection == 2 && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown("joystick 1 button 0") || Input.GetKeyDown("joystick 2 button 0")))
		{
			#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
			#elif UNITY_STANDALONE
				UnityEngine.Application.Quit();
			#endif
		}


		//--------------------------------------------------------------------- 関数: ロッカールーム
		// UPDATE: ロッカールーム関連
		//----------------------------------------

		// ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
		// ロッカールームの入力はここです！
		// ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

		// カーソル値変更
		if (ScreenState == 1 && ((Input.GetAxis("Horizontal") == 1) && (a == true)))
        {
			audioSource.PlayOneShot(sfxCursor);
			SelectionCursor++;
			a = false;
			Invoke("AT",0.5f);
		}
		else if (ScreenState == 1 && ((Input.GetAxis("Horizontal") == -1) && (a == true)))
        {
			audioSource.PlayOneShot(sfxCursor);
			SelectionCursor--;
			a = false;
			Invoke("AT", 0.5f);
		}

		if (SelectionCursor > 3)
			SelectionCursor = 0;
		else if (SelectionCursor < 0)
			SelectionCursor = 3;
			
		/*
		// カーソル制限
		if (ScreenState == 1 && SelectionCursor > 3 && Input.GetKeyDown("right"))
        {
			audioSource.PlayOneShot(sfxCursor);
			SelectionCursor = 0;
		}
		else if (ScreenState == 1 && SelectionCursor < 0 && Input.GetKeyDown("left"))
        {
			audioSource.PlayOneShot(sfxCursor);
			SelectionCursor = 2;
		}
		*/
		

		// カーソル移動
		if(SelectionCursor == 0)
        {
			cursor0.SetActive(true);
			cursor1.SetActive(false);
			cursor2.SetActive(false);
			cursor3.SetActive(false);
		}
		else if (SelectionCursor == 1)
		{
			cursor0.SetActive(false);
			cursor1.SetActive(true);
			cursor2.SetActive(false);
			cursor3.SetActive(false);
		}
		else if (SelectionCursor == 2)
		{
			cursor0.SetActive(false);
			cursor1.SetActive(false);
			cursor2.SetActive(true);
			cursor3.SetActive(false);
		}
		else if (SelectionCursor == 3)
		{
			cursor0.SetActive(false);
			cursor1.SetActive(false);
			cursor2.SetActive(false);
			cursor3.SetActive(true);
		}


		if (ScreenState == 0)
		{
			f1Canvas.SetActive(true);
			f2Canvas.SetActive(false);
			
			kl0Wrapper.SetActive(false);
			redRibbon.SetActive(false);
		}
		else
		{
			f1Canvas.SetActive(false);
			f2Canvas.SetActive(true);
			
			kl0Wrapper.SetActive(true);
			redRibbon.SetActive(true);
		}
		
		
		switch(NowSkinSelection)
		{
			case 0:
				lk0skin0.SetActive(true);
				lk0skin1.SetActive(false);
				lk0skin2.SetActive(false);
				lk0skin3.SetActive(false);
				break;
			
			case 1:
				lk0skin0.SetActive(false);
				lk0skin1.SetActive(true);
				lk0skin2.SetActive(false);
				lk0skin3.SetActive(false);
				break;
			
			case 2:
				lk0skin0.SetActive(false);
				lk0skin1.SetActive(false);
				lk0skin2.SetActive(true);
				lk0skin3.SetActive(false);
				break;
			
			case 3:
				lk0skin0.SetActive(false);
				lk0skin1.SetActive(false);
				lk0skin2.SetActive(false);
				lk0skin3.SetActive(true);
				break;
		}
		
		
		//--------------------------------------------------------------------- 関数: スキン
		// UPDATE: スキン関連
		//----------------------------------------
		
		switch(Pc1Skin)
		{
			case 0:
				pc1skin0.SetActive(true);
				pc1skin1.SetActive(false);
				pc1skin2.SetActive(false);
				pc1skin3.SetActive(false);
				break;
			
			case 1:
				pc1skin0.SetActive(false);
				pc1skin1.SetActive(true);
				pc1skin2.SetActive(false);
				pc1skin3.SetActive(false);
				break;
			
			case 2:
				pc1skin0.SetActive(false);
				pc1skin1.SetActive(false);
				pc1skin2.SetActive(true);
				pc1skin3.SetActive(false);
				break;
			
			case 3:
				pc1skin0.SetActive(false);
				pc1skin1.SetActive(false);
				pc1skin2.SetActive(false);
				pc1skin3.SetActive(true);
				break;
		}
		
		switch(Pc2Skin)
		{
			case 0:
				pc2skin0.SetActive(true);
				pc2skin1.SetActive(false);
				pc2skin2.SetActive(false);
				pc2skin3.SetActive(false);
				break;
			
			case 1:
				pc2skin0.SetActive(false);
				pc2skin1.SetActive(true);
				pc2skin2.SetActive(false);
				pc2skin3.SetActive(false);
				break;
			
			case 2:
				pc2skin0.SetActive(false);
				pc2skin1.SetActive(false);
				pc2skin2.SetActive(true);
				pc2skin3.SetActive(false);
				break;
			
			case 3:
				pc2skin0.SetActive(false);
				pc2skin1.SetActive(false);
				pc2skin2.SetActive(false);
				pc2skin3.SetActive(true);
				break;
		}
	}
	
	
	void PlayBgm()
	{
		TitleBgm.Play();
	}
}
