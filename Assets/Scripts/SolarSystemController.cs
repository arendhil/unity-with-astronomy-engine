using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{
	public static float planetDistanceConvertMultiplier = 10f;
	public float secondToDaysFactor = 1f;
	DateTime startTime;

	void Start() {
		startTime = DateTime.Now;
	}

	private void FixedUpdate() {
		movePlanets();
	}

	public void movePlanets() {
		float delta = DateTime.Now.Subtract(startTime).Seconds * secondToDaysFactor;
		DateTime simulationTime = startTime.AddDays(delta);
		PlanetSetup[] planets = this.transform.GetComponentsInChildren<PlanetSetup>();
		foreach (var planet in planets) {
			planet.Move(simulationTime);
		}
	}
}
