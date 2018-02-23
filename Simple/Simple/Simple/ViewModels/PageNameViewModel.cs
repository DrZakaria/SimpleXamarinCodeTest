using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Simple.Infrastructure;

namespace Simple.ViewModels
{
    public class PageNameViewModel : AppMapViewModelBase
    {


        public PageNameViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
