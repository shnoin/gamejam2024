using UnityEngine;

public class FollowCam2 : MonoBehaviour
{
	[Header("REFERENCES")]
	public Camera cam;
	private GameManager gameManager;

	void Start()
	{
		gameManager = FindFirstObjectByType<GameManager>();
	}

	void Update()
	{
		// If current camera is current camera + player control is on
		if (!gameManager.getCamera() && gameManager.getLock())
		{
			// Set transform to camera rotation
			Vector3 newRotation = transform.eulerAngles;
			newRotation.y = cam.transform.localEulerAngles.y;
			transform.eulerAngles = newRotation;
		}
	}
}