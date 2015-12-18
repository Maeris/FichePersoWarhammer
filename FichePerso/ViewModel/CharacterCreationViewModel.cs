using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichePerso.ViewModel
{
    public class CharacterCreationViewModel : ViewModelBase
    {
        #region Attributes

        public INavigationService _navigationService { get; set; }

        #endregion

        public CharacterCreationViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
