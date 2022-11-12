using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;


public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    void DeleteBreakfast(Guid id);
    void UpsertBreakfast(Breakfast breakfast);
}
