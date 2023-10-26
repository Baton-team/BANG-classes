using System;
using System.Collections.Generic;

class Role
{
    public string Name { get; set; }

    public Role(string name)
    {
        Name = name;
    }

    public void PrintRoleName()
    {
        Console.WriteLine(Name);
    }
}

class Sheriff : Role
{
    public Sheriff() : base("Sheriff")
    {
    }
}

class Renegade : Role
{
    public Renegade() : base("Renegade")
    {
    }
}

class Bandit : Role
{
    public Bandit() : base("Bandit")
    {
    }
}


