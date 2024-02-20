using Models.Entities;

namespace Models;

public class IndexViewModel
{
    public List<PrivateChef> ? PrivateChefs {get;set;}
    public List<MssgTherapy> ? MssgTherapies {get;set;}
    public List<OfferedService> ? OfferedServices {get;set;}
    public List<FutureEvent> ? FutureEvents {get;set;}
}