using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Simple.Infrastructure;

namespace Simple.ViewModels
{
    public class MasterDetailViewModel : AppMapViewModelBase
    {


        public MasterDetailViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
