using System.Runtime.Serialization;

namespace SOAPWebApiAssignment.Model.Response
{
    [DataContract]
    public class OutputResponse
    {
        [DataMember]
        public double Output {  get; set; }
        [DataMember]
        public string? ErrorMessage { get; set; }
        [DataMember]
        public bool IsSuccessful { get; set; }
    }
}
