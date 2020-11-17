using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Player Player;
    public Transform begin;
    public Transform end;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
                transform.position.x,
                transform.position.y - Player.Speed,
                transform.position.z
                );
    }
}
