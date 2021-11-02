using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SolarSystemController))]
[CanEditMultipleObjects]
public class SolarSystemControllerEditor : Editor {
	public override void OnInspectorGUI() {
		base.OnInspectorGUI();

		SolarSystemController solarSystem = (SolarSystemController)target;

		if (GUILayout.Button("Move")) {
			solarSystem.movePlanets();
		}
	}

}
