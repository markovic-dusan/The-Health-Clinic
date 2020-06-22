// File:    Patient.cs
// Author:  Vaxi
// Created: Friday, March 20, 2020 4:32:04 PM
// Purpose: Definition of Class Patient

using Model.Patient;
using Model.Survey;
using System;

namespace Model.Users
{
    public class PatientModel : RegisteredUser
    {
        private bool isAccommodated;

        public bool IsAccommodated
        {
            get { return isAccommodated; }
            set { isAccommodated = value; OnPropertyChanged("IsAccommodated"); }
        }

        private string accommodation;

        public string Accommodation
        {
            get { return accommodation; }
            set { accommodation = value; OnPropertyChanged("Accommodation"); }
        }


        public System.Collections.Generic.List<SurveyResponse> surveyResponses;
        public System.Collections.Generic.List<SurveyResponse> SurveyResponses
        {
            get
            {
                if (surveyResponses == null)
                    surveyResponses = new System.Collections.Generic.List<SurveyResponse>();
                return surveyResponses;
            }
            set
            {
                RemoveAllSurveyResponses();
                if (value != null)
                {
                    foreach (SurveyResponse oSurveyResponse in value)
                        AddSurveyResponses(oSurveyResponse);
                }
            }
        }
        public void AddSurveyResponses(SurveyResponse newSurveyResponse)
        {
            if (newSurveyResponse == null)
                return;
            if (this.surveyResponses == null)
                this.surveyResponses = new System.Collections.Generic.List<SurveyResponse>();
            if (!this.surveyResponses.Contains(newSurveyResponse))
            {
                this.surveyResponses.Add(newSurveyResponse);
                newSurveyResponse.Patient = this;
            }
        }

        public void RemoveSurveyResponses(SurveyResponse oldSurveyResponse)
        {
            if (oldSurveyResponse == null)
                return;
            if (this.surveyResponses != null)
                if (this.surveyResponses.Contains(oldSurveyResponse))
                {
                    this.surveyResponses.Remove(oldSurveyResponse);
                    oldSurveyResponse.Patient = null;
                }
        }
        public void RemoveAllSurveyResponses()
        {
            if (surveyResponses != null)
            {
                System.Collections.ArrayList tmpSurveyResponses = new System.Collections.ArrayList();
                foreach (SurveyResponse oldSurveyResponse in surveyResponses)
                    tmpSurveyResponses.Add(oldSurveyResponse);
                surveyResponses.Clear();
                foreach (SurveyResponse oldSurveyResponse in tmpSurveyResponses)
                    oldSurveyResponse.Patient = null;
                tmpSurveyResponses.Clear();
            }
        }
        public RoomsHistory[] roomsHistory;
    }
}