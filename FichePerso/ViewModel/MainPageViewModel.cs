using FichePerso.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FichePerso.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Attributes

        public INavigationService _navigationService { get; set; }

        private ObservableCollection<CharacterModel> CharactersList;

        #endregion

        public MainPageViewModel()
        {
            CreateNewCharacterCommand = new RelayCommand(() => CreateNewCharacterExecute(), () => true);
        }

        #region Commands

        public ICommand CreateNewCharacterCommand { get; private set; }

        private void CreateNewCharacterExecute()
        {
            // TODO
            // Ouvrir page de création de personnage
        }

        #endregion

        private void NavigateTo(string pageKey, object parameters = default(object))
        {
            this._navigationService.NavigateTo(pageKey, parameters);
        }
    }
}