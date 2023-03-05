using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static Utilities;

public class ModelChecker : MonoBehaviour
{
    GameObject[] childrens;
    public void ChildrenCheck()
    {
        childrens = GetChildrenRecursive(this.gameObject);
        for (int i = 0; i < childrens.Length; i++)
        {
            Component[] components = childrens[i].GetComponents<Component>();
            if (components.Length > 1)
            {
                RemoveThisAndParentToArray(childrens[i].transform);
                childrens[i] = null;
            }
        }

        for (int i = childrens.Length - 1; i >= 0; i--)
        {
            if (EqualityComparer<GameObject>.Default.Equals(childrens[i], default(GameObject)))
            {
                continue;
            }
            DestroyImmediate(childrens[i]);
        }
    }

    void RemoveThisAndParentToArray(Transform childTransform)
    {
        if (childTransform.parent != null || childTransform.parent == childTransform.root)
        {
            RemoveThisAndParentToArray(childTransform.parent);
        }
        RemoveToReferenceTypesArray(childrens, childTransform.gameObject);
    }

    GameObject[] GetChildrenRecursive(GameObject parent)
    {
        // 親を含む子オブジェクトを再帰的に取得
        Transform[] parentAndChildren = parent.GetComponentsInChildren<Transform>();
        GameObject[] parentAndChildrenObject = new GameObject[parentAndChildren.Length];
        for (int i = 0; i < parentAndChildren.Length; i++)
        {
            parentAndChildrenObject[i] = parentAndChildren[i].gameObject;
        }
        // 子オブジェクトの格納用配列作成
        GameObject[] children = new GameObject[parentAndChildren.Length - 1];

        // 親を除く子オブジェクトを結果にコピー
        Array.Copy(parentAndChildrenObject, 1, children, 0, children.Length);

        // 子オブジェクトが再帰的に格納された配列
        return children;
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(ModelChecker))]
    public class ModelCheckerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            ModelChecker modelChecker = target as ModelChecker;
            base.OnInspectorGUI();
            bool onCheck = GUILayout.Button("Check");
            if (onCheck == true)
            {
                modelChecker.ChildrenCheck();
            }
        }

        
    }
#endif
}
