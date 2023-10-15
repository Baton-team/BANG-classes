namespace BANG-classes;

public class Role
{
    public string Name { get; }

    public Role(string name)
    {
		try
		{
			switch (name)
			{
				case "Sheriff":
                    Name = "Sheriff";
                    break;
                case "Bandit":
                    Name = "Bandit";
                    break;
                case "Assistant":
                    Name = "Assistant";
                    break;
                case "Renegade":
                    Name = "Renegade";
                    break;
                default:
					break;
			}
		}
		catch ()
		{
            //the name is not suitable
            throw new ArgumentException("The name is not suitable.");
        }
    }
}
