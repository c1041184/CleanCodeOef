using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeOef
{
    class Oef8
    {


        
    class Flight
        {
            /*
          * Origin / Destination numbers.
          */

            public const int FRANKFURT = 0;
            public const int LONDON = 1;
            public const int MADRID = 2;
            public const int PARIS = 3;
            public const int STOCKHOLM = 4;

            /*
             * Aircraft model numbers.
             */
            public const int AIRBUS_A380 = 0;
            public const int AIRBUS_A340_600 = 1;
            public const int BOEING_747_400 = 2;
            public const int AIRBUS_A321 = 3;
            /*
             * Instance variables
             */
            /**
             * Flight origin number.
             */
            private int mOrigin;
            /**
             * Flight destination number.
             */
            private int mDestination;
            /**
             * Aircraft model number for this flight.
             */
            private int mAircraft;
            /**
             * Airline flight number.
            */
            private int mFlightNumber;
            /*
             * Constructors
             */
            /**
             * Construct a flight object with specified origin, destination, aircraft
            * and fight number.
             * 
             * @param pFlightNumber the flight number, a positive integer.
             * @param pOrigin the origin number for the flight.
             * @param pDestination the destination number for the flight.
             * @param pAircraft the aircraft model number.
             * @throws FlightException thrown if an illegal origin / destination, aircraft model or
             *                         flight number is specified. 
             */

            public Flight(int pFlightNumber, int pOrigin, int pDestination, int pAircraft)
            {
                if (pOrigin >= 0 && pOrigin <= 4)
                {
                    mOrigin = pOrigin;
                }
                else
                {
                    throw new Exception("Incorrect airport number.");
                }

                if (pDestination >= 0 && pDestination <= 4)
                {
                    mDestination = pDestination;
                }
                else
                {
                    throw new Exception("Incorrect airport number.");
                }

                if (pAircraft >= 0 && pAircraft <= 3)
                {
                    mAircraft = pAircraft;
                }
                else
                {
                   throw new Exception("Incorrect aircraft number.");
                }
                if (pFlightNumber >= 0)
                {
                    mFlightNumber = pFlightNumber;
                }
                else
                {
                    throw new Exception("Negative flight number");
                }
            }

            /*
             * Methods
             */
            /**
             * Change the origin airport of this flight.
             * 
             * @param pOrigin the new origin airport number.
             * @throws FlightException if the specified airport number is illegal.
             */
            public void ChangeOrigin(int pOrigin)
            {
                if (pOrigin >= 0 && pOrigin <= 4)
                {
                    mOrigin = pOrigin;
                }
                else
                {
                   throw new Exception("Incorrect airport number.");
                }
            }
            /**
             * Change the destination airport of this flight
             * 
             * @param pDestination the new destination airport number.
             * @throws FlightException if the specified airport number is illegal.
             */
            public void ChangeDestination(int pDestination)

            {
                if (pDestination >= 0 && pDestination <= 4)
                {
                    mDestination = pDestination;
                }
                else
                {
                    throw new Exception("Incorrect airport number.");
                }
            }

            /**
             * Change the aircraft used in this flight.
             * 
             * @param pAircraft the new aircraft number.
             * @throws FlightException if the specified aircraft number is illegal.
             */
            public void ChangeAircraft(int pAircraft)

            {
                if (pAircraft >= 0 && pAircraft <= 3)
                {
                    mAircraft = pAircraft;
                }
                else
                {
                    throw new Exception("Incorrect aircraft number.");
                }
            }

            /**
             * Calculate the cost per passenger for this flight. Assumes that the
             * flight consists of two legs origin -> Frankfurt and Frankfurt -> destination.
             * 
             * @return the total cost of this flight to a passenger.
             */
            public double CalculateCost()
            {
                // Different aircraft incur different costs per kilometer per passenger.

                double vCostFactor = 0;
                switch (mAircraft)
                {
                    case AIRBUS_A380: vCostFactor = 0.3; break;
                    case AIRBUS_A340_600: vCostFactor = 0.35; break;
                    case BOEING_747_400: vCostFactor = 0.45; break;
                    case AIRBUS_A321: vCostFactor = 0.4; break;
                }
                // Distance from Frankfurt to origin airport.
                double vOriginDistance = 0;
                switch (mOrigin)
                {
                    case FRANKFURT: vOriginDistance = 0; break;
                    case LONDON: vOriginDistance = 609.3; break;
                    case MADRID: vOriginDistance = 1420.8; break;
                    case PARIS: vOriginDistance = 475.9; break;
                    case STOCKHOLM: vOriginDistance = 1195.4; break;
                }

                // Distance from Frankfurt to destination airport.

                double vDestinationDistance = 0;
                switch (mDestination)

                {
                    case FRANKFURT: vDestinationDistance = 0; break;
                    case LONDON: vDestinationDistance = 609.3; break;
                    case MADRID: vDestinationDistance = 1420.8; break;
                    case PARIS: vDestinationDistance = 475.9; break;
                    case STOCKHOLM: vDestinationDistance = 1195.4; break;
                }
                // Cost is equal to total distance via Frankfurt airport
                // multiplied by the cost factor.

                return vCostFactor * (vOriginDistance + vDestinationDistance);
            }


            public override string ToString()
            {
                String vResult;
                vResult = "Flight number : " + mFlightNumber;
                switch (mOrigin)

                {
                    case FRANKFURT: vResult += ", Origin : Frankfurt (FRA)"; break;
                    case LONDON: vResult += ", Origin : London (LHR)"; break;
                    case MADRID: vResult += ", Origin : Madrid (MAD)"; break;
                    case PARIS: vResult += ", Origin : Paris (CDG)"; break;
                    case STOCKHOLM: vResult += ", Origin : Stockholm (ARN)"; break;
                }
                switch (mDestination)
                {
                    case FRANKFURT: vResult += ", Destination : Frankfurt (FRA)"; break;
                    case LONDON: vResult += ", Destination : London (LHR)"; break;
                    case MADRID: vResult += ", Destination : Madrid (MAD)"; break;
                    case PARIS: vResult += ", Destination : Paris (CDG)"; break;
                    case STOCKHOLM: vResult += ", Destination : Stockholm (ARN)"; break;
                }

               switch (mAircraft)

                {
                    case AIRBUS_A380: vResult += ", Aircraft : Airbus A380."; break;
                    case AIRBUS_A340_600: vResult += ", Aircraft : Airbus A340-400."; break;
                    case BOEING_747_400: vResult += ", Aircraft : Boeing 747-400."; break;
                    case AIRBUS_A321: vResult += ", Aircraft : Airbus A321."; break;

                }
                return vResult;
            }
        }

    }
}

