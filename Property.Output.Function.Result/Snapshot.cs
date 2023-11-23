using Property = Tumbleweed.Property.Output;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Property.Output.Function.Result;

public sealed class Snapshot<T> : Property::Envelope<T>
{
	public Snapshot(System::Func<T> function) : this
	(
		new Function::From.System<T>(function)
	)
	{
	}
	
	public Snapshot(Function::Any<T> function) : base
	(
		new Property::Snapshot.One<T>(
			new Property::Function.Result.Actual<T>(function))
	)
	{
	}
}