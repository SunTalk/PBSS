using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraController : MonoBehaviour
{
    [Header("Player")]
    public GameObject Player;

    [Header("Camera Range by Tilemap")]
    public Tilemap tileMap;
    public GameObject CameraLimit;
    private float xMin, xMax, yMin, yMax;

    private void Start()
    {
        OnValidate();

        //Vector3 minTile = tileMap.CellToWorld(tileMap.cellBounds.min);
        //Vector3 maxTile = tileMap.CellToWorld(tileMap.cellBounds.max);
        Vector3 minTile = -CameraLimit.GetComponent<SpriteRenderer>().sprite.bounds.extents + CameraLimit.transform.position;
        Vector3 maxTile = CameraLimit.GetComponent<SpriteRenderer>().sprite.bounds.extents + CameraLimit.transform.position;

        SetLimits(minTile, maxTile);
    }

    private void LateUpdate()
    {
        //Vector3 cPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //Vector3 tPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        //transform.position = Vector3.Lerp(cPosition, tPosition, target.movement.speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(Player.transform.position.x, xMin, xMax), Mathf.Clamp(Player.transform.position.y, yMin, yMax), transform.position.z);
    }

    private void SetLimits(Vector3 minTile, Vector3 maxTile)
    {
        Camera cam = Camera.main;

        float height = 2f * cam.orthographicSize;
        float weight = height * cam.aspect;

        xMin = minTile.x + weight / 2;
        xMax = maxTile.x - weight / 2;

        yMin = minTile.y + height / 2;
        yMax = maxTile.y - height / 2;

    }

    private void OnValidate()
    {
        Debug.Assert(Player != null);
        //Debug.Assert(tileMap != null);
        Debug.Assert(CameraLimit != null);
    }
}
