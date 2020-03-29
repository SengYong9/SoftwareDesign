//
// ICT2106 Software Design - Vending machine example using the State pattern
//
// Class representing a vending machine in the "vend" state.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.VendingMachineOO
{
    class VendVendingMachineState : VendingMachineState
    {
        private decimal cost;
        // constructor
        public VendVendingMachineState(VendingMachine VMIn, decimal costIn) : base(VMIn)
        {
            cost = costIn;
        }

        // enter state handler
        public override void OnEntry()
        {
            // print a message
            VM.Display("Vending an item worth $" + cost);

            // reduce the amount of money by the cost of the item and print a message
            VM.Amount -= cost;

            // move to the next state
            if (VM.Amount == 0.0M)
            {
                // no change to return, return back to idle state
                VM.EnterState(new MakeChangeVendingMachineState(VM));
            }
            else if(VM.fixAmount >= VM.Amount)
            {
                // change is required.
                VM.EnterState(new MakeChangeVendingMachineState(VM));

            } else {
                 // no change required; go back to idle
                VM.Display("Exact Change Only");
                VM.Display("Please insert the exact amount only");
                VM.flag = true;
                VM.EnterState(new IdleVendingMachineState(VM));
            }
        }

        // insert money handler
        public override void Insert(decimal amountIn)
        {
            VM.Display("Please wait until the current item has been dispensed.");
        }

        // select item handler
        public override void Select(decimal cost)
        {
            VM.Display("Please wait until the current item has been dispensed.");
        }
    }
}
