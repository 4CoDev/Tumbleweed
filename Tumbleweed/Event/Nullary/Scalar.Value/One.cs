using Event = Tumbleweed.Event;
using Scalar = Tumbleweed.Scalar.Immutable;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary.Scalar.Value;

public sealed class One : Event::Envelope<Procedure::Any>
{
	public One
	(
		Scalar::Any<Event::Any<Procedure::Any>> scalar
	) : base
	(
		new Event::Scalar.Value.One<Procedure::Any>(scalar)
	)
	{
	}
}