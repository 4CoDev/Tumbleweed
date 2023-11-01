using Group = DotGod.Engine.Input.Event.Group;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Engine.Input.Event.Group.Function.Result;

public sealed class One : Group::Envelope
{
	public One(System::Func<Group::Any> function) : this
	(
		new Function::From.System<Group::Any>(function)
	)
	{
	}
	
	public One(Function::Any<Group::Any> function) : base
	(
		new Group::Property.Value.One(
			new Property::Function.Result.Actual
				<Group::Any>
				(function))
	)
	{
	}
}