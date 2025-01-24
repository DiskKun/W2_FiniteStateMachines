using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class StinkMove : ActionTask {

		public Transform pointToMove; // the point to move towards
		public float speed; // the speed at which to move towards it
		public float moveThreshold; // the distance the character needs to reach within in order to stop moving

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			Vector3 direction = (pointToMove.position - agent.transform.position).normalized;
			agent.transform.position += direction * speed * Time.deltaTime;
			if (Vector3.Distance(agent.transform.position, pointToMove.position) < moveThreshold)
			{
				EndAction();
			}
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}