using Group = DotGod.Engine.Input.Event.Group;
using Property = Tumbleweed.Property.Output;
using Event = Tumbleweed.Event;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Engine.Input.Event.Group.Property.Value;

public sealed class One : Group::Any
{
	public One(Property::Any<Group::Any> property) =>
		this.property = property;

	public Event::Any<Procedure::Any> Handled =>
		property.Value.Handled;

	public Event::Any<Procedure::Any> Unhandled =>
		property.Value.Unhandled;

	private readonly Property::Any<Group::Any> property;
}