
using System;

namespace pan_pets.core {
    public class Pet {
        public string Id { get; set; }
        public PetType Type { get; set; }
        public string Name { get; set; }

        public ValidationResult Validate () {
            // Basic model validation on api side for sake of brevity
            var result = new ValidationResult ();

            if (Type == PetType.None) {
                result.IsValid = false;
                result.Messages.Add ("Pet type not specified.");
            }

            if (string.IsNullOrWhiteSpace (Name)) {
                result.IsValid = false;
                result.Messages.Add ("Name cannot be empty.");
            }

            result.PetId = Id;
            return result;
        }
    }
}