﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeScene
{
    sealed class CharacterDraw : MonoBehaviour
    {
        [SerializeField]
        private GameObject messageWindow;
        [SerializeField]
        private Sprite[] characterImages = new Sprite[5]; 
        [SerializeField]
        private bool isDebug = false;

        [SerializeField]
        private GameObject soundManager;

        private string characterName;
        private string characterSpeech;
        private Sprite characterImage;
        private Charactor character;

        private CharacterDraw() { }

        private void Start()
        {
            if (isDebug)
            {
                TestUI(1);
            }
            else
            {
                ReferenceCharacterData();
                DrawMessageText();
                DrawCharacterImage();
            }

            messageWindow.SetActive(false);
        }

        public void OnClickCharacter()
        {
            StartCoroutine("ShowMessageWindow");
        }

        private void ReferenceCharacterData()
        {
            if (Master.formationdeta.selectcharactor1 != null)
            {
                character = (Charactor)Master.formationdeta.selectcharactor1;

                if (character.name == "幽霊")
                {
                    this.characterName = character.name;
                    this.characterImage = characterImages[0];
                    this.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(-360.48f, -75.0f);
                    this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1025.0f,760.0f);
                    return;
                }
                if (character.name == "座敷童")
                {
                    this.characterName = character.name;
                    this.characterImage = characterImages[1];
                    this.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(-390.48f, -0.0f);
                    this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1760.0f, 950.0f);
                    return;
                }
                if (character.name == "鬼")
                {
                    this.characterName = character.name;
                    this.characterImage = characterImages[2];
                    this.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(-360.48f, -75.0f);
                    this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1370.0f, 760.0f);
                    return;
                }
                if (character.name == "ポルターガイスト")
                {
                    this.characterName = character.name;
                    this.characterImage = characterImages[3];
                    this.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(-360.48f, -75.0f);
                    this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(970.0f, 630.0f);
                    return;
                }
                if (character.name == "悪魔")
                {
                    this.characterName = character.name;
                    this.characterImage = characterImages[4];
                    this.gameObject.GetComponent<RectTransform>().localPosition = new Vector2(-360.48f, -75.0f);
                    this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1370.0f, 760.0f);
                    return;
                }
            }
        }

        private void DrawMessageText()
        {
            messageWindow.transform.GetChild(1).GetComponent<Text>().text = this.characterName;
            messageWindow.transform.GetChild(2).GetComponent<Text>().text = this.characterSpeech;
        }

        private void DrawCharacterImage()
        {
            this.gameObject.GetComponent<Image>().sprite = characterImage;
        }


        private IEnumerator ShowMessageWindow()
        {
            messageWindow.SetActive(true);

            int randomNum = Random.Range(0,5);

            if (character.name == "幽霊")
            {
                characterSpeech = HomeScene_Deta.ghostSpeechTexts[randomNum];
                soundManager.GetComponent<SoundManager>().PlayVoice(randomNum);
            }
            if (character.name == "座敷童")
            {
                characterSpeech = HomeScene_Deta.zasikiwarasiSpeechTexts[randomNum];
                soundManager.GetComponent<SoundManager>().PlayVoice(randomNum + 5);
            }
            if (character.name == "鬼")
            {
                characterSpeech = HomeScene_Deta.oniSpeechTexts[randomNum];
                soundManager.GetComponent<SoundManager>().PlayVoice(randomNum + 10);
            }
            if (character.name == "ポルターガイスト")
            {
                characterSpeech = HomeScene_Deta.poltergeistSpeechTexts[randomNum];
                soundManager.GetComponent<SoundManager>().PlayVoice(randomNum + 15);
            }
            if (character.name == "悪魔")
            {
                characterSpeech = HomeScene_Deta.demonSpeechTexts[randomNum];
                soundManager.GetComponent<SoundManager>().PlayVoice(randomNum + 20);
            }

            messageWindow.transform.GetChild(2).GetComponent<Text>().text = characterSpeech;

            yield return new WaitForSeconds(5.0f);
            messageWindow.SetActive(false);
            yield break;
        }

        private void TestUI(int characterNum)
        {
            switch (characterNum)
            {
                case 0:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Ghost";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "A";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[0];
                    break;
                case 1:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Zasikiwarasi";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "B";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[1];
                    break;
                case 2:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Oni";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "C";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[2];
                    break;
                case 3:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Poltergeist";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "D";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[3];
                    break;
                case 4:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Demon";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "E";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[4];
                    break;
            }
        }
    }
}