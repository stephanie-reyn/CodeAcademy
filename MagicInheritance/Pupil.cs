using System;
namespace MagicInheritance
{
    class Pupil
    {
    // Properties
     public string Title
     {get; private set; }

     public string Origin
     {get; private set; }

    // Constructor
    public Pupil (string title, string origin)
    {
        this.Title = title;
        this.Origin = origin;
    }

    // Method
    public Storm CastWindStorm()
    {
        return new Storm("wind", false, this.Title);
    }




    }
}