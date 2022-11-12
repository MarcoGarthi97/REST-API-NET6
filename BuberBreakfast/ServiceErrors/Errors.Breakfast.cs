using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.NotFound",
            description: $" Breakfast name must be at last {Models.Breakfast.MinNameLength} characters long and at most {Models.Breakfast.MaxNameLength} characters long."
        );

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.NotFound",
            description: $" Breakfast description must be at last {Models.Breakfast.MinDescriptionLength} characters long and at most {Models.Breakfast.MaxDescriptionLength} characters long."
        );

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found"
        );

    }
}
