using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace app.ViewModels
{
    class notaViewModels
    {
        string NotesId;
        string Contents;
        public DateTime CreatedDate
        public DateTime ModifiedDate
        bool isrunning;
        private object thow;
        #region Propiedades
        public string NoteId {
        get {return this.NoteId}
        set { SetValue(ref this nota, value); }
        }
        public string Contents {
            get { return this.Contents; }
            set { SetValue(ref this.Contents, value)}
        }

        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public DateTime CreatedDate
        { get { return this.CreatedDate; }
          set { SetValue(ref this.CreatedDate, value); }
}
        public DateTime ModifiedDate
        {
            get { return this.ModifiedDate; }
            set { SetValue(ref this.ModifiedDate, value); }
        }

        #endregion
        #region comandos
        public ICommand LoginCommand{
get{return new RelayCommand(Login)}
}
private void Login()
{
    thow new NoImplementedException();
}
#endregion

    }
}
