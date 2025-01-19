using MediatR;

namespace TaskRira.Presentation.Servies
{
    public class PersonService
    {
        private readonly IMediator _mediator;

        public PersonService(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
