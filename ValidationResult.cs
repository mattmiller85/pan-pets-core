
using System;
using System.Collections.Generic;

namespace pan_pets.core {
    public class ValidationResult {
        public bool IsValid { get; set; } = true;
        public string PetId { get; set; }
        public List<string> Messages { get; set; } = new List<string> ();
    }
}