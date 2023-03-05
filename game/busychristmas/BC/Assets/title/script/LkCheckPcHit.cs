using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LkCheckPcHit : MonoBehaviour
{
	GameObject fadePanel;
	GameObject camera1F;
	GameObject camera2F;
	Animation fade;
	Animation f1CamOut;
	Animation f2CamIn;
	GameObject wipePanel;

	GameObject pc1Header;
	GameObject pc2Header;


	public AudioClip sfxDeside;
	public AudioClip sfxBack;
	AudioSource sfx;

	byte usingPc;


	void Start()
	{
		camera1F = GameObject.Find("MainCamera");
		camera2F = GameObject.Find("LockerCamera");
		fadePanel = GameObject.Find("FadePanel");
		wipePanel = GameObject.Find("TransPanel");

		// ÉAÉjÉÅ
		fade = fadePanel.GetComponent<Animation>();
		f1CamOut = camera1F.GetComponent<Animation>();
		f2CamIn = camera2F.GetComponent<Animation>();

		pc1Header = GameObject.Find("Pc1HeaderText");
		pc2Header = GameObject.Find("Pc2HeaderText");

		sfx = GetComponent<AudioSource>();


		camera2F.SetActive(false);
		camera1F.SetActive(true);

		wipePanel.SetActive(false);
	}

	void Update()
	{
		if (TitleScreen.ScreenState == 1 && (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("B1")))
		{
			if (usingPc == 1)
			{
				sfx.PlayOneShot(sfxDeside);
				TitleScreen.NowSkinSelection = TitleScreen.SelectionCursor;
				TitleScreen.Pc1Skin = TitleScreen.NowSkinSelection;
			}
			else if (usingPc == 2)
			{
				sfx.PlayOneShot(sfxDeside);
				TitleScreen.NowSkinSelection = TitleScreen.SelectionCursor;
				TitleScreen.Pc2Skin = TitleScreen.NowSkinSelection;
			}
		}

		if (TitleScreen.ScreenState == 1 && (Input.GetKeyDown(KeyCode.Backspace)|| Input.GetButtonDown("A1")))
		{

			sfx.PlayOneShot(sfxBack);
			wipePanel.SetActive(true);
			Invoke("ChangeCamera2to1", 0.5f);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		TitleScreen.isLockerUsing = true;

		f1CamOut.Play("1f_out");
		fade.Play("fadeout");

		Invoke("ChangeCam_LockerIn", 0.5f);

		TitleScreen.SelectionCursor = TitleScreen.NowSkinSelection;


		if (collision.gameObject.name == "Pc1Wrapper")
		{
			usingPc = 1;

			pc1Header.SetActive(true);
			pc2Header.SetActive(false);

			TitleScreen.NowSkinSelection = TitleScreen.Pc1Skin;

			Invoke("SetReturnPosPc1", 0.5f);
		}
		else if (collision.gameObject.name == "Pc2Wrapper")
		{
			usingPc = 2;

			pc1Header.SetActive(false);
			pc2Header.SetActive(true);

			TitleScreen.NowSkinSelection = TitleScreen.Pc2Skin;

			Invoke("SetReturnPosPc2", 0.5f);
		}
	}


	void ChangeCam_LockerIn()
	{
		camera1F.SetActive(false);
		camera2F.SetActive(true);
		TitleScreen.ScreenState = 1;
		fade.Play("fadein");
		f2CamIn.Play("2f_in");
	}

	void ChangeCam_LockerOut()
	{
		wipePanel = GameObject.Find("TransPanel");
		TitleScreen.ScreenState = 0;
		wipePanel.SetActive(true);
		Invoke("ChangeCamera2to1", 0.5f);
	}

	void SetReturnPosPc1()
	{
		TitleScreen.pc1Wrapper.transform.position = new Vector3(4.5f, 0, -1.8f);
	}

	void SetReturnPosPc2()
	{
		TitleScreen.pc2Wrapper.transform.position = new Vector3(6.5f, 0, -1.8f);
	}

	void ChangeCamera2to1()
	{
		camera1F.SetActive(true);
		camera1F.transform.position = new Vector3(10.26f, 8.63f, 3.0f);
		TitleScreen.ScreenState = 0;
		camera2F.SetActive(false);
		Invoke("ReturnWipePanel", 1.2f);
	}

	void ReturnWipePanel()
    {
		wipePanel.SetActive(false);
	}
}
