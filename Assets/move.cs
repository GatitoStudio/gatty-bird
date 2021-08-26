using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
  // 1 - Designer variables
	void Start()
	{
		
	}
  /// <summary>
  /// Vitesse de déplacement
  /// </summary>
  public Vector2 speed = new Vector2(5, 5);

  /// <summary>
  /// Direction
  /// </summary>
  public Vector2 direction = new Vector2(10, 0);

  private Vector2 movement;

  void Update()
  {
    // 2 - Calcul du mouvement
    movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y);
  }

  void FixedUpdate()
  {
		GetComponent<Rigidbody2D>().velocity = movement;
  }
}
