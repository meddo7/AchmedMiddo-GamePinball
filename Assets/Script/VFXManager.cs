using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject VfxController;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VfxController, spawnPosition, Quaternion.identity);
    }
}
