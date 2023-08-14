using Group = DotGod.Engine.Iteration.Event.Group;
using Scalar = Tumbleweed.Scalar.Immutable;
using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Scalar.Value;

public sealed class One : Group::Any
{
	public One(Scalar::Any<Group::Any> scalar) =>
		this.scalar = scalar;

	public Event::Any<Procedure::Any> Graphical =>
		scalar.Value.Graphical;

	public Event::Any<Procedure::Any> Physical =>
		scalar.Value.Physical;

	private readonly Scalar::Any<Group::Any> scalar;
}