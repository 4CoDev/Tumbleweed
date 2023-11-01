using Group = DotGod.Engine.Iteration.Event.Group;
using Property = Tumbleweed.Property.Output;
using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Iteration.Event.Group.Property.Value;

public sealed class One : Group::Any
{
	public One(Property::Any<Group::Any> property) =>
		this.property = property;

	public Event::Any<Procedure::Any> Graphical =>
		property.Value.Graphical;

	public Event::Any<Procedure::Any> Physical =>
		property.Value.Physical;

	private readonly Property::Any<Group::Any> property;
}