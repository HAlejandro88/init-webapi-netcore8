namespace BuberBreakfast.Contracts.Breakfast;

public class CreateBreakfastRequest
    (
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet
    );