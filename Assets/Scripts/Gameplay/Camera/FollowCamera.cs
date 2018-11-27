using UnityEngine;

public class FollowCamera : MonoBehaviour 
{
    [SerializeField]
    Transform followTarget;

    Vector3 previousPosition = Vector3.negativeInfinity;

	// Update is called once per frame
	void FixedUpdate() 
    {
        if(followTarget)
        {
            if(!previousPosition.Equals(Vector3.negativeInfinity))
            {
                transform.position += followTarget.position - previousPosition;
            }
            previousPosition = followTarget.position;
        }
	}

    public void Follow(Transform followTarget)
    {
        this.followTarget = followTarget;
    }
}
