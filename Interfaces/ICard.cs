using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANG-classes.Interfaces;

internal interface ICard
{
    string Name { get; }
    bool playable;

    void PlayOn(IPlayer target);
}