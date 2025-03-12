using MediatR;
using PersonHandle2.Models;

namespace PersonHandle2.Controllers.features.people.GetPersonById
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;
    
}
