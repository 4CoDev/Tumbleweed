using Tumbleweed.Dictionary;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.Reaction.Of;

public sealed class Listeners : NullaryProcedure.Envelope
{
	public Listeners
	(
		IDictionary<System::Object, NullaryProcedure.Any> listeners
	) : base
	(
		new NullaryProcedure.Of.Procedures(
			new ValuesOfDictionary<NullaryProcedure.Any>(listeners))
	)
	{
	}
}