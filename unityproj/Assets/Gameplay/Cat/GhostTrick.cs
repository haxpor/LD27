using UnityEngine;
using System.Collections;

public class GhostTrick : MonoBehaviour {
	public float ghostTrickSlowTimeScale = 0.2f;
	public float ghostTrickActiveDuration = 0.6f;	// in secs
	
	private float ghostTrickCountingTimeActiveDuration = 0.0f;
	private bool isGhostTrickActivated = false;
	
	// gesture to drab objects
	private bool isFirstClick = true;
	private Vector3 mousePosition_ghostTrick_pos1;
	public float distanceClick = 2000;
	public float dragGesture_effectiveDistance = 50;
	private GameObject targetObstaclesInDragged;
	public float factorDraggedDistance = 2.3f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(CountDownTimer.instance.GetTimeRemaining() > 0.0f)
		{
			if(Input.GetButtonDown("GhostTrick") && !isGhostTrickActivated && PlayerInfo.instance.numberOfGhostTrickUsed > 0)
			{
				PlayerInfo.instance.numberOfGhostTrickUsed--;
				isGhostTrickActivated = true;
				
	            Time.timeScale = ghostTrickSlowTimeScale;
	            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
	            Time.fixedDeltaTime = 0.02F * Time.timeScale;
	            gameObject.BroadcastMessage("GhostTrickOn", SendMessageOptions.DontRequireReceiver);
			}
			
			// counting down time
			if(isGhostTrickActivated)
			{
				ghostTrickCountingTimeActiveDuration += Time.deltaTime;
				//Debug.Log ("Ghosttrick time: " + ghostTrickCountingTimeActiveDuration);
				
				// process raycaster if any
				if(Input.GetMouseButton(0))
				{
					if(isFirstClick)
					{
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						RaycastHit hit;
						
						if(Physics.Raycast(ray, out hit, distanceClick))
						{
							if(hit.collider.gameObject.tag == "Obstacles")
							{
								if(hit.collider.gameObject.renderer != null)
								{
									hit.collider.gameObject.renderer.material.color = Color.red;
								}
								
								// save target obstacles in dragging
								targetObstaclesInDragged = hit.collider.gameObject;
								
								Debug.Log ("Clicked on " + hit.collider.gameObject.name);
							}
						}
						
						// not the first click anymore
						isFirstClick = false;
						// save the starting of dragging gesture
						mousePosition_ghostTrick_pos1 = Input.mousePosition;
					}
					else
					{
						// convert to our in-used coordinate as we're different from screen-space
						Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.z, Input.mousePosition.y);
						
						float distance = Vector3.Distance(mousePosition_ghostTrick_pos1, Input.mousePosition);
						
						// if reach effective range
						if(targetObstaclesInDragged != null &&
						   distance >= dragGesture_effectiveDistance)
						{
							if(targetObstaclesInDragged.renderer != null)
								targetObstaclesInDragged.renderer.material.color = Color.green;
							Debug.Log ("Dragged and reached effective range");
							
							// check direction to drag
							//Vector3 convertedMousePosition = new Vector3(Input.mousePosition.x, , -Input.mousePosition.y);
							Vector3 draggedDir = Input.mousePosition - mousePosition_ghostTrick_pos1;
							draggedDir = Vector3.Normalize(draggedDir);
							
							// convert into game-space
							Vector3 convertedDir = new Vector3(draggedDir.x, 0.0f, draggedDir.y);
							
							// move or exert target obstacle
							targetObstaclesInDragged.transform.position += convertedDir * factorDraggedDistance;
						}
					}
				}
				
				// if reach the active duration then go back to normal
				if(ghostTrickCountingTimeActiveDuration >= ghostTrickActiveDuration)
				{
					Debug.Log ("entered");
					
					// reset states
					isGhostTrickActivated = false;
					ghostTrickCountingTimeActiveDuration = 0.0f;
					
					// reset ghosttrick temporary variables
					isFirstClick = true;
					mousePosition_ghostTrick_pos1 = Vector3.zero;
					targetObstaclesInDragged = null;
					
					Time.timeScale = 1.0f;
					
		            // If you lower timeScale it is recommended to also lower Time.fixedDeltaTime by the same amount.
		            Time.fixedDeltaTime = 0.02F * Time.timeScale;
		            gameObject.BroadcastMessage("GhostTrickOff", SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
