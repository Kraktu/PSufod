using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Orientation
{
	south,
	southWest,
	west,
	northWest,
	north,
	northEast,
	east,
	southEast
}
public class Player : MonoBehaviour
{
	string userName;
	int[] worldpos = new int[2];
	int localPos;
	Orientation myOrientation;
}
