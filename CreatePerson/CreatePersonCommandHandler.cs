using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using PersonHandle2.Models;

namespace PersonHandle2.Controllers.features.people.CreatePerson
{
    public record CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
    {
        private readonly PersonApiContext _context;

        public CreatePersonCommandHandler(PersonApiContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var Person = new Person { Id = request.Id, Firstname = request.Firstname, Lastname = request.Lastname, Age = request.Age };
            _context.People.Add(Person);
            await _context.SaveChangesAsync();

            return Person.Id;
        }
    }
}
