namespace Draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// If it exceeds 160C we need to event the cooling system.
            /// </summary>
            public bool IsNougatTooHot() {
                int temp = CandyBarMaker.CheckNougatTemperature();
                if (temp > 160)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ///<summary>
            /// Perform the Candy Isolation Cooling System (CICS) vent procedure.
            /// </summary>
            public void DoCICSVentProcedures() {                
                TurbineController turbines = new TurbineConroller();
                turbines.CloseTripValce(2);                
                IsolationCoolingSystem.Fill();
                IsolationCoolingSytem.Vent();                
                Maker.CheckAirSystem();             
            }
            public void ThreeMinuteCheck()
            {
                if (IsNougatTooHot() == true)
                {
                    DoCICSVentProcedure();
                }
            }

        }
    }
}
