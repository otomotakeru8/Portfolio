using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Loading : MonoBehaviour
{
	public static Loading instance;
	private void Start() {
        if(instance == null) {
			instance = this;
		}
    }
    //　非同期動作で使用するAsyncOperation
    private AsyncOperation async;
	//　シーンロード中に表示するUI画面
	[SerializeField]
	private GameObject loadUI;
	//　読み込み率を表示するスライダー
	[SerializeField]
	private Slider slider;
	//ロードするsceneの名前を入力
	[SerializeField]public static string Scenename = "title";
	//ロードするときはnextscene関数を呼び出す。
	//loading.Scenenameにロードしたいsceneの名前を代入する
	public void NextScene()
	{
		Debug.Log("ロードした");
		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);

		//　コルーチンを開始
		StartCoroutine("LoadData");
	}

	IEnumerator LoadData()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync(Scenename);

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
}
