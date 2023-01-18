using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthInfoController : MonoBehaviour
{
    private MeshRenderer renderer;
    // private LODGroup lodgroup;
    // void Start()
    // {
    //     lodgroup = GetComponent<LODGroup>();
    //     // renderer = lodgroup.GetLODs().GetComponentsInChildren<MeshRenderer>();
    //     LOD[] lods = lodgroup.GetLODs();
    //     for (int i = 0; i < lods.Length; i++)
    //          {
    //             Renderer[] temp = lods[i].renderers;
    //             for (int j = 0; j < temp.Length; j++)
    //                  {
    //                     renderer = temp[j].GetComponent<Renderer>();
    //                  }
    //          }
    // }

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
	    renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
