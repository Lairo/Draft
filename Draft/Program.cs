namespace Draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* This code tuns every 3 minutes to check the temperature.
             * If it exceeds 160C we need to event the cooling system.
             */

            int t = m.chkTemp();
            if (t > 160)
            {
                // Get the controller system for the turbines
                T tb = new T();

                //Close throttle valve on turbine #2
                tb.clsTrpV(2);

                // Fill and vent the isolation cooling system
                ics.Fill();
                ics.Vent();

                // Initiate the air system check
                m.airsyschk();
            }
        }
    }
}
