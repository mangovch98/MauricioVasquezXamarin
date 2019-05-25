using app.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.Interfaces
{
    public class InstanceLocator
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        #endregion

        #region ViewModels
        public notaViewModels Login { get; set; }
        #endregion

        #region Constructors
       public InstanceLocator()
        {
            instance = this;
            this.Login = new notaViewModels();
        }
        #endregion
        #region Singleton
        private static mainViewModel instance;

        public static mainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new mainViewModel();
            }
            return instance;
        }
        #endregion



    }
}
