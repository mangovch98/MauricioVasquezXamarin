using System;
using System.Collections.Generic;
using System.Text;
using app.Interfaces;

namespace app.ViewModels
{
    class mainViewModel
    {
        public static implicit operator mainViewModel(InstanceLocator v)
        {
            throw new NotImplementedException();
        }
    }
}
