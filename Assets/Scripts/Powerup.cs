using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Powerup : MonoBehaviour {
    public int powerup_id;

    public int get_power_id() {
        return powerup_id;
    }

    private void Update() {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }
}
