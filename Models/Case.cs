using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedisoftDemo.Models
{
    public class Case
    {
        public Guid Id { get; set; }
        public DateTime time { get; set; }
        public string CaseType { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighhbour { get; set; }
        public string Street { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PatientInformation { get; set; }
        public string ComplaintDefinition { get; set; }
        public string FirstAid { get; set; }
        public Guid SelectedAmbulance { get; set; }
        public Guid SelectedTechnician { get; set; }
        public List<string> MediaPaths { get; set; }


    }
}