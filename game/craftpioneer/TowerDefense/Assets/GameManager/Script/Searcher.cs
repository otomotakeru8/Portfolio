using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Searcher : MonoBehaviour
{
    float m_minSphereRadius = 0.25f;
    public GameObject[] SearchObjectsByName(Vector3 targetPos, float radius, string name)
    {
        List<GameObject> objects = Searching(targetPos, radius);
        for (int i = 0; i < objects.Count; i++)
        {
            if (objects[i].name.Contains(name) == false)
            {
                objects.Remove(objects[i]);
            }
        }
        return objects.ToArray();
    }
    public GameObject SearchObjectByName(Vector3 targetPos, float radius, string name)
    {
        List<GameObject> objects = Searching(targetPos, radius);
        for (int i = 0; i < objects.Count; i++)
        {
            if (objects[i].name.Contains(name) == false)
            {
                objects.Remove(objects[i]);
            }
        }
        return Sort(targetPos, objects);
    }
    public GameObject[] SearchObjectsByTag(Vector3 targetPos, float radius, string tag)
    {
        List<GameObject> objects = Searching(targetPos, radius);
        for (int i = 0; i < objects.Count; i++)
        {
            if (objects[i].tag.Contains(tag) == false)
            {
                objects.Remove(objects[i]);
            }
        }
        return objects.ToArray();
    }
    public GameObject SearchObjectByTag(Vector3 targetPos, float radius, string tag)
    {
        List<GameObject> objects = Searching(targetPos, radius);
        for (int i = 0; i < objects.Count; i++)
        {
            if (objects[i].tag.Contains(tag) == false)
            {
                objects.Remove(objects[i]);
            }
        }
        return Sort(targetPos, objects);
    }

    List<GameObject> Searching(Vector3 pivot, float radius)
    {
        List<GameObject> objects = new List<GameObject>();
        for (float r = radius; r >= m_minSphereRadius; r -= 0.25f)
        {
            Collider[] colliderArray = Physics.OverlapSphere(pivot, r);
            for (int i = 0; i < colliderArray.Length; i++)
            {
                objects.Add(colliderArray[i].gameObject);
            }
        }
        objects.Distinct();
        return objects;
    }

    GameObject Sort(Vector3 pivot, List<GameObject> gameObjects)
    {
        (float d, GameObject g)[] gameObjectInfo = new (float d, GameObject g)[gameObjects.Count];
        for (int i = 0; i < gameObjectInfo.Length; i++)
        {
            gameObjectInfo[i].d = Vector3.Distance(pivot, gameObjects[i].transform.position);
            gameObjectInfo[i].g = gameObjects[i];
        }
        Array.Sort(gameObjectInfo);
        if (gameObjectInfo.Length != 0)
        {
            return gameObjectInfo[0].g;
        }
        return null;
    }
}
