using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviourScript : MonoBehaviour
{
  	public UnityEvent startEvent, awakeEvent, disableEvent;
	  

	private void Awake()
	{
		awakeEvent.Invoke();
	}

    void Start()
    {
        startEvent.Invoke();
    }
	private void OnDisable()
	{
		disableEvent.Invoke();
	}
}
