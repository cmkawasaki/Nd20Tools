using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Nd20StatblockGenerator.TemplateInfo
{
    public enum MovementTypes
    {
        Normal,
        Fly,
        Burrow,
        Climb,
        Swim
    }

    public enum FlightQuality
    {
        NotApplicable,
        Clumsy,
        Poor,
        Average,
        Good,
        Perfect
    }

    [Serializable]
    public class MovementType
    {
        public int MovementInFeet;
        public MovementTypes TypeOfMovement;
        [DefaultValue(FlightQuality.NotApplicable)]
        public FlightQuality FlightQuality;

        public static string PrintMovementTypes(List<MovementType> listofMovementTypes)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < listofMovementTypes.Count; i++)
            {
                if (i != 0)
                {
                    builder.Append(", ");
                }
                builder.Append(PrintMovementType(listofMovementTypes[i]));
            }
            return builder.ToString();
        }

        public static string PrintMovementType(MovementType type)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(type.MovementInFeet);
            builder.Append(" ft.");

            if (type.TypeOfMovement != MovementTypes.Normal)
            {
                builder.Append(" ");
                builder.Append(type.TypeOfMovement.ToString().ToLower());

                if (type.TypeOfMovement == MovementTypes.Fly)
                {
                    builder.Append(" (");
                    builder.Append(type.FlightQuality.ToString().ToLower());
                    builder.Append(")");
                }
            }

            return builder.ToString();
        }
    }



}
