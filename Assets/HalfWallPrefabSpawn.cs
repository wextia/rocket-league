﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class HalfWallPrefabSpawn : MonoBehaviour {

    [SerializeField]
    GameObject wallFragment;

    GameObject[] fragments = new GameObject[5];

    void OnEnable()
    {
        for (int i = 0; i < fragments.Length; i++)
        {
            if (fragments[i] != null)
            {
                DestroyImmediate(fragments[i]);
                fragments[i] = null;
            }

            GameObject go = Instantiate(wallFragment, Vector3.zero,
                transform.rotation, transform);
            go.transform.localPosition = new Vector3(
                0, 0, i * 5f - 22.5f);
            fragments[i] = go;
        }
    }
    void OnDisable()
    {
        for (int i = 0; i < fragments.Length; i++)
        {
            if (fragments[i] != null)
            {
                DestroyImmediate(fragments[i]);
                fragments[i] = null;
            }
        }
    }
}