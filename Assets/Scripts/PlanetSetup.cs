using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CosineKitty;
using System;

public class PlanetSetup : MonoBehaviour {
	public enum PLANET { SUN, MERCURY, VENUS, EARTH, MARS, JUPITER, SATURN, NEPTUNE, PLUTO }

	public PLANET planet;
	Body planetBody = Body.Sun;

	bool isSun = false;

	private void Awake() {
		setPlanet();
	}

	void setPlanet() {
		isSun = false;
		switch (planet) {
			case PLANET.SUN:
				planetBody = Body.Sun;
				isSun = true;
				break;
			case PLANET.MERCURY:
				planetBody = Body.Mercury;
				break;
			case PLANET.VENUS:
				planetBody = Body.Venus;
				break;
			case PLANET.EARTH:
				planetBody = Body.Earth;
				break;
			case PLANET.MARS:
				planetBody = Body.Mars;
				break;
			case PLANET.JUPITER:
				planetBody = Body.Jupiter;
				break;
			case PLANET.SATURN:
				planetBody = Body.Saturn;
				break;
			case PLANET.NEPTUNE:
				planetBody = Body.Neptune;
				break;
			case PLANET.PLUTO:
				planetBody = Body.Pluto;
				break;
			default:
				break;
		}
	}

	public void Move(DateTime time) {
		AstroVector av = Astronomy.HelioVector(planetBody, new AstroTime(time));
		this.transform.localPosition = 
			new Vector3(
				Convert.ToSingle(av.x),
				Convert.ToSingle(av.y),
				Convert.ToSingle(av.z)) * SolarSystemController.planetDistanceConvertMultiplier;
	}
}
