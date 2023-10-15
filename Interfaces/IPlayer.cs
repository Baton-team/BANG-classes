using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANG-classes.Interfaces;

internal interface IPlayer
{
	string Name { get; set; }
	int Health { get; set; }
	Role Role { get; set; }

	void UseCard(IPlayer target, ICard card);

	void IsDeath();
}