using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Wibble))]
public class WibbleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Wibble wibble = target as Wibble;
        wibble.wibbleValue = UnboundSlider("Wibblage", -15, 297, wibble.wibbleValue);
        wibble.wobbleValue = UnboundSlider("Wobblage", 100, 1000, wibble.wobbleValue);
    }

    private int UnboundSlider(string label, int min, int max, int currentValue)
    {
        // TODO: Implement this method as described.
        throw new System.NotImplementedException("Test 3 not started");
    }

}
