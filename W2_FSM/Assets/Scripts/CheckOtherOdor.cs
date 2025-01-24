using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CheckOtherOdor : ConditionTask {
		public BBParameter<GameObject> stinkGameObject; // this is always the OTHER FSM owner / character.
		Blackboard stinkBlackBoard;
        public enum Comparison { greaterThan, lessThan }
        public Comparison comparison;
        public float what; // to compare against what number?

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			stinkBlackBoard = stinkGameObject.value.GetComponent<Blackboard>();
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            if (comparison == Comparison.greaterThan)
            {
                if (stinkBlackBoard.GetVariableValue<float>("odor") > what)
                {
                    return true;
                }
            }
            else
            {
                if (stinkBlackBoard.GetVariableValue<float>("odor") < what)
                {
                    return true;
                }
            }

            return false;
        }
	}
}