
using System;
using System.Collections.Generic;

namespace pan_pets.core {
    public interface IPetsRepository {
        Pet Get (string id);
        List<Pet> GetAll ();
        bool HasId(string id);
        ValidationResult Save (Pet pet);
    }
}