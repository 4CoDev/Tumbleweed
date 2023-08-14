using Group = DotGod.Engine.Input.Event.Group;
using Scalar = Tumbleweed.Scalar.Immutable;
using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group.Scalar.Value;

public sealed class One : Group::Any
{
	public One(Scalar::Any<Group::Any> scalar) =>
		this.scalar = scalar;

	public Event::Any<Procedure::Any> Handled =>
		scalar.Value.Handled;

	public Event::Any<Procedure::Any> Unhandled =>
		scalar.Value.Unhandled;

	private readonly Scalar::Any<Group::Any> scalar;
}