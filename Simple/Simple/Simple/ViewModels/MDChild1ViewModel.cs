using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Simple.Infrastructure;

namespace Simple.ViewModels
{
    public class MDChild1ViewModel : AppMapViewModelBase
    {


        public MDChild1ViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
