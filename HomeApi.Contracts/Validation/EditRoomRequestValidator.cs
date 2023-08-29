using FluentValidation;
using HomeApi.Contracts.Models.Rooms;

namespace HomeApi.Contracts.Validation
{
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.Area).NotEmpty();
            RuleFor(x => x.Voltage).NotEmpty().InclusiveBetween(120, 220);
            RuleFor(x => x.GasConnected).NotNull();
        }
    }
}
