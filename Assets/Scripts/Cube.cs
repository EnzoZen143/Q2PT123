using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IInteractable {
    public void Interact() {
        Debug.Log(Random.Range(1, 100));
    }
}
