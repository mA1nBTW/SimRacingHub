using System.Text.Json.Serialization;

namespace SimRacingHub.Domain
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(F125Parameters), typeDiscriminator: "f1")]
    [JsonDerivedType(typeof(LmuHypercarParameters), typeDiscriminator: "lmu")]

    public abstract class SetupParametersBase
    {
    }

    //F1 25 Inheritence
    public class F125Parameters : SetupParametersBase
    {
        public double FrontWing { get; set; }
        public double RearWing { get; set; }
        public double DifferentialAdjustmentOnThrottle { get; set; }
        //public double DifferentialAdjustmentOffThrottle { get; set; }
        //public double FrontCamber { get; set; }
        //public double RearCamber { get; set; }
        //public double FrontToe { get; set; }
        //public double RearToe { get; set; }
        //public double FrontSuspension { get; set; }
        //public double RearSuspension { get; set; }
        //public double FrontAntiRollBar { get; set; }
        //public double RearAntiRollBar { get; set; }
        //public double FrontRideHeight { get; set; }
        //public double RearRideHeight { get; set; }
        //public double BrakePressure { get; set; }
        //public double BrakeBias { get; set; }
        //public double FrontTyrePressure { get; set; }
        //public double RearTyrePressure { get; set; }
    }

    //LMU Hypercar Inheritence
    public class LmuHypercarParameters : SetupParametersBase
    {
        public double FrontWing { get; set; }
        public double RearWing { get; set; }
        public double DifferentialAdjustmentOnThrottle { get; set; }
        public double DifferentialAdjustmentOffThrottle { get; set; }
        public double FrontCamber { get; set; }
        public double RearCamber { get; set; }
        public double FrontToe { get; set; }
        public double RearToe { get; set; }
        public double FrontSuspension { get; set; }
        public double RearSuspension { get; set; }
        public double FrontAntiRollBar { get; set; }
        public double RearAntiRollBar { get; set; }
        public double FrontRideHeight { get; set; }
        public double RearRideHeight { get; set; }
        public double BrakePressure { get; set; }
        public double BrakeBias { get; set; }
        public double FrontTyrePressure { get; set; }
        public double RearTyrePressure { get; set; }
    }
}