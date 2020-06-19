// File:    MedicineDataBaseRepositoryFactory.cs
// Author:  Vaxi
// Created: Friday, May 29, 2020 6:01:16 PM
// Purpose: Definition of Class MedicineDataBaseRepositoryFactory

using System;

namespace Repository.MedicineRepo
{
   public class MedicineDataBaseRepositoryFactory : MedicineRepositoryFactory
   {
      public MedicineRepository CreateMedicineRepository()
      {
         throw new NotImplementedException();
      }
   
   }
}