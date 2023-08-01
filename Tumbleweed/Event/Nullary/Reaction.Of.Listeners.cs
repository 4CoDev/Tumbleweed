using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using SCG = System.Collections.Generic;
using System = System;
using Tumbleweed.Dictionary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.Reaction.Of;

public sealed class Listeners : Procedure::Envelope
{
	public Listeners
	(
		SCG::IDictionary<System::Object, Procedure::Any> listeners
	) : base
	(
		new Procedure::Of.Procedures(
			new ValuesOfDictionary<Procedure::Any>(listeners))
	)
	{
	}
}