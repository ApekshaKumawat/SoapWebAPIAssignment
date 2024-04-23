using System.Runtime.Serialization;

namespace SOAPWebApiAssignment.Model.Request
{
    [DataContract]
    public class InputRequest
    {
        [DataMember]
        public double Operand1 { get; set; }
        [DataMember]
        public double Operand2 { get; set; }
    }
}
