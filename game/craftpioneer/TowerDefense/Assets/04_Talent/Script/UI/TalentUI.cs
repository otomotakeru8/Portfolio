using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class TalentUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform root;
    Transform area;
    Transform self;
    CanvasGroup canvasGroup = null;
    GameObject m_nameText;
    GameObject m_descriptionText;

    public void Awake()
    {
        self = transform;
        area = self.parent;
        root = area.root;
        m_nameText = transform.GetChild(1).gameObject;
        m_descriptionText = transform.GetChild(2).gameObject;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        self.SetParent(root);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        self.localPosition = GetLocalPosition(eventData.position, transform);
    }

    private static Vector3 GetLocalPosition(Vector3 position, Transform transform)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.root.GetComponent<RectTransform>(), position, Camera.main, out Vector2 result);
        return new Vector3(result.x, result.y, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        TalentFrameUI dropArea = GetRaycastArea(eventData);
        if (dropArea != null)
        {
            if (dropArea.GetTalent() == null)
            {
                area.GetComponent<TalentFrameUI>().TakeTalent();
                area = dropArea.transform;
                self.SetParent(area);
                dropArea.SetTalent(gameObject);
            }
            else if (dropArea.CanStack == true && dropArea.GetTalent() == gameObject)
            {
                area.GetComponent<TalentFrameUI>().TakeTalent();
                area = dropArea.transform;
                self.SetParent(area);
                dropArea.SetTalent(gameObject);
            }
        }
        self.SetParent(area);
        self.localPosition *= 0;
        canvasGroup.blocksRaycasts = true;
    }

    private void OnMouseEnter()
    {
        string name = m_descriptionText.transform.parent.name;
        string translationName = name.Remove(name.Length - 7).Insert(0, name[0].ToString().ToLower()).Remove(1, 1);
        m_nameText.GetComponent<Text>().text = Translation.GetTranslationText(translationName);
        m_nameText.SetActive(true);
        m_descriptionText.GetComponent<Text>().text = TalentUIText.GenerateTalentUIText(name).Replace(" ", "\u00A0");
        m_descriptionText.SetActive(true);
    }

    private void OnMouseExit()
    {
        m_nameText.SetActive(false);
        m_descriptionText.SetActive(false);
    }

    /// <summary>
    /// イベント発生地点の DropArea を取得する
    /// </summary>
    /// <param name="eventData">イベントデータ</param>
    /// <returns>TalentFrameUI</returns>
    private static TalentFrameUI GetRaycastArea(PointerEventData eventData)
    {
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        return results.Select(x => x.gameObject.GetComponent<TalentFrameUI>()).FirstOrDefault(x => x != null);
    }
}
