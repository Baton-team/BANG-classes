using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANG-classes.Interfaces;

internal interface ICharacter : IPlayer
{
	string CharacterName { get; }
	int MaxHealth { get; }

	void UseCard(IPlayer target, ICard card);
}

