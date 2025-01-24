using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using TMPro;

namespace NodeCanvas.Tasks.Actions {

	public class ChangeOdor : ActionTask {
		public BBParameter<float> stinkOdor; // this is always the odor variable of the FSM owner.
		public float changeAmount; // the factor by which the odor will be changed (always use a positive value)
		public enum AddOrSubtract { increment, decrement }
		public AddOrSubtract addOrSubtract; // choose to increment or decrement the odor
		public TextMeshProUGUI label; // update the canvas element
		public string color; // the name of the character


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
			if (addOrSubtract == AddOrSubtract.decrement)
			{
                stinkOdor.value -= Time.deltaTime * changeAmount; // change the odor by the amount
				label.text = color + " Odor: " + Mathf.RoundToInt(stinkOdor.value); // update the text canvas element
            } else
			{
				stinkOdor.value += Time.deltaTime * changeAmount;
                label.text = color + " Odor: " + Mathf.RoundToInt(stinkOdor.value);
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