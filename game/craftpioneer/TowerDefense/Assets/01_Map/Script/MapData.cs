using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapData", menuName = "ScriptableObjects/MapData", order = 1)]

public class MapData : ScriptableObject
{
    public List<Vector3> CastlePosition = new List<Vector3>();
    public List<Vector3> Village1Position = new List<Vector3>();
    public List<Vector3> Village2Position = new List<Vector3>();

    public List<Vector3> EnemySpawnPosition = new List<Vector3>();

    public List<List<Vector2>> EnemyMoveRoute = new List<List<Vector2>>();

    public void Initialize()
    {
        CastlePosition = new List<Vector3>();
        Village1Position = new List<Vector3>();
        Village2Position = new List<Vector3>();
        EnemySpawnPosition = new List<Vector3>();
        EnemyMoveRoute = new List<List<Vector2>>();

    }
}
