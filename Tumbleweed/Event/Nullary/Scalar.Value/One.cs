using Event = Tumbleweed.Event;
using Property = Tumbleweed.Property.Output;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary.Property.Value;

public sealed class One : Event::Envelope<Procedure::Any>
{
	public One
	(
		Property::Any<Event::Any<Procedure::Any>> property
	) : base
	(
		new Event::Property.Value.One<Procedure::Any>(property)
	)
	{
	}
}