using System;

namespace Odev7_Interface.Models;

public interface IIdentifiable
{
    int Id { get; }
    string GetDisplayName();

}
