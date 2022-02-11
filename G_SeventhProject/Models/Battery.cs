namespace G_SeventhProject.Models
{
    public class Battery
    {
        public static int charges {get; set;}

        public Battery(){
            charges = 3;

            Calculator.EventCalculatorUsed += EventHandler;
        }

        private void BatteryDown(){
            charges--;
        }

        public void EventHandler(){
            BatteryDown();
        }


    }


}