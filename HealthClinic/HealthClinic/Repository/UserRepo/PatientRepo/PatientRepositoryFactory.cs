﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Repository.UserRepo.PatientRepo
{
    interface PatientRepositoryFactory
    {
        PatientRepository CreatePatientRepository();
    }
}
