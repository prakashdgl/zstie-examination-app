﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSTIE.ViewModels.Notifiers
{
    interface INotifyChangeView
    {
        void ChangeView(ViewModelBase viewModelBase);
    }
}
