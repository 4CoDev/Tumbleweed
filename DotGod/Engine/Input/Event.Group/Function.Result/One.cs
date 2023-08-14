using Group = DotGod.Engine.Input.Event.Group;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

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
		new Group::Scalar.Value.One(
			new Scalar::Function.Result.Actual
				<Group::Any>
				(function))
	)
	{
	}
}