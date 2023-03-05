using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator
{
    ShapeSettings settings;
    NoiseFilter[] noiseFilter;

    public ShapeGenerator(ShapeSettings settings)
    {
        this.settings = settings;
        noiseFilter = new NoiseFilter[settings.noiseLayers.Length];
        for (int i = 0; i < noiseFilter.Length; i++)
        {
            noiseFilter[i] = new NoiseFilter(settings.noiseLayers[i].noiseSettings);
        }
    }

    public Vector3 CalculatePointOnPlanet(Vector3 pointOnitSphere)
    {
        float firstLayerValue = 0;
        float elevation = 0;

        if (noiseFilter.Length > 0)
        {
            firstLayerValue = noiseFilter[0].Evaluate(pointOnitSphere);
            if (settings.noiseLayers[0].enabled)
            {
                elevation = firstLayerValue;
            }
        }

        for (int i = 1; i < noiseFilter.Length; i++)
        {
            if (settings.noiseLayers[i].enabled)
            {
                float mask = (settings.noiseLayers[i].useFirstLayerAsMask) ? firstLayerValue : 1;
                elevation += noiseFilter[i].Evaluate(pointOnitSphere) * mask; 
            }
        }
        return pointOnitSphere * settings.planetRadius * (1 + elevation);
    }
}
