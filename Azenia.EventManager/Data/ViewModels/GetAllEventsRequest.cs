using Azenia.EventManager.Data.Enums;

namespace Azenia.EventManager.Data.ViewModels;

public class GetAllEventsRequest
{
    public string? OrderByKey { get; set; }
    public OrderByEnum OrderBy { get; set; } = OrderByEnum.ASC; 
}

