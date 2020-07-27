using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using MinoxBeard.ViewModels;

namespace MinoxBeard.Helpers
{
    public static class ViewModelLocator
    {

        public static RecordViewModel RecordViewModel => ServiceLocator.Current.GetInstance<RecordViewModel>();
        public static AddRecordViewModel AddRecordViewModel => ServiceLocator.Current.GetInstance<AddRecordViewModel>(); 
        public static RoutineViewModel RoutineViewModel => ServiceLocator.Current.GetInstance<RoutineViewModel>();
        public static AddRoutineViewModel AddRoutineViewModel => ServiceLocator.Current.GetInstance<AddRoutineViewModel>();
        

    }
}
