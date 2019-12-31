﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel()
        {
            SandBoxViewModel sand = (SandBoxViewModel) IoC.GetInstance(typeof(SandBoxViewModel), null);
            WorkViewModel work = (WorkViewModel)IoC.GetInstance(typeof(WorkViewModel), null);

            Items.Add(sand); 
            Items.Add(work);
            ActivateItem(work);
        }
    }
}