namespace Syncfusion.Dashboard.Server.Api.Helper.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class DisplayValueMember
    {
        [DataMember(Name = "displayMember")]
        public string DisplayMember { get; set; }
        [DataMember(Name = "valueMember")]
        public string ValueMember { get; set; }
    }
}
