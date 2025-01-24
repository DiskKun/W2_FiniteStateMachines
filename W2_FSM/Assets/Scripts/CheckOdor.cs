using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckOdor : ConditionTask {
		public BBParameter<float> stinkOdor; // this is always the odor variable of the FSM owner.
		public enum Comparison { greaterThan, lessThan }
		public Comparison comparison;
		public float what; // the amount to compare the odor to

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
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
			if (comparison == Comparison.greaterThan) // compare odor, return true if comparison is true
			{
     
                return stinkOdor.value > what;
                
            } else
			{

                return stinkOdor.value < what;
 
            }
			
		}
	}
}