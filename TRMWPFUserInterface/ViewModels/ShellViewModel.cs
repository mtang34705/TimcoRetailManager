using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;
using TRMWPFUserInterface.EventModels;

namespace TRMWPFUserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        private SimpleContainer _container;
        public ShellViewModel(IEventAggregator events,SalesViewModel salesVM,SimpleContainer container)
        {
            _salesVM = salesVM;
            _container = container;
            _events = events;
#pragma warning disable CS0618 // Type or member is obsolete
            _events.Subscribe(this);
#pragma warning restore CS0618 // Type or member is obsolete
            ActivateItemAsync(_container.GetInstance<LoginViewModel>());
        }

        public Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            return ActivateItemAsync(_salesVM);
        }
    }
}
