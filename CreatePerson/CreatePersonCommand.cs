using MediatR;

namespace PersonHandle2.Controllers.features.people.CreatePerson
{
    public record CreatePersonCommand(int Id, string Firstname, string Lastname, int Age) : IRequest<int>;
}
