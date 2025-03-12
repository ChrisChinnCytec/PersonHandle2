using MediatR;
using PersonHandle2.Models;

namespace PersonHandle2.Controllers.features.people.GetPersonById
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly PersonApiContext _context;

        public GetPersonByIdQueryHandler(PersonApiContext context)
        {
            _context = context;
        }
        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var Person = await _context.People.FindAsync(request.Id);
            return Person;
        }
    }
}
