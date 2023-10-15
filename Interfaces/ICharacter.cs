using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANG-classes.Interfaces;

internal interface ICharacter
{
	string Name { get; }
	int Health { get; }

	void UseCard(ICard card);
}

