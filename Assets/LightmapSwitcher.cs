using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakedLightmapSwitcher : MonoBehaviour
{
    // Arrays to store lightmap textures
    public Texture2D[] lightmapSet1; // First lightmap set
    public Texture2D[] lightmapSet2; // Second lightmap set

    private int currentSetIndex = 0;

    // Method to switch to the next lightmap set
    public void SwitchLightmapSet()
    {
        // Cycle between lightmap sets
        currentSetIndex = (currentSetIndex + 1) % 2;  // Switch between 2 lightmap sets

        if (currentSetIndex == 0)
        {
            ApplyLightmapSet(lightmapSet1);
        }
        else
        {
            ApplyLightmapSet(lightmapSet2);
        }
    }

    // Apply the chosen lightmap set to the scene
    private void ApplyLightmapSet(Texture2D[] lightmapSet)
    {
        if (lightmapSet == null || lightmapSet.Length == 0)
        {
            Debug.LogError("Invalid lightmap set.");
            return;
        }

        // Prepare the LightmapData array
        LightmapData[] lightmapDataArray = new LightmapData[lightmapSet.Length];

        // Assign textures to the LightmapData array
        for (int i = 0; i < lightmapSet.Length; i++)
        {
            lightmapDataArray[i] = new LightmapData();
            lightmapDataArray[i].lightmapColor = lightmapSet[i]; // Assuming 'lightmapFar' stores the main lightmap
        }

        // Apply the lightmap data to the scene
        LightmapSettings.lightmaps = lightmapDataArray;
        Debug.Log("Switched to lightmap set: " + (currentSetIndex + 1));
    }

    // Optionally, a method to switch lightmaps based on an index
    public void SetLightmapSet(int index)
    {
        if (index == 0)
        {
            ApplyLightmapSet(lightmapSet1);
        }
        else if (index == 1)
        {
            ApplyLightmapSet(lightmapSet2);
        }
        else
        {
            Debug.LogError("Invalid lightmap set index.");
        }
    }
}