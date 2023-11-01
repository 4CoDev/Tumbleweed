using Property = Tumbleweed.Property.Output;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Property.Output.Function.Result;

public sealed class Lazy<T> : Property::Envelope<T>
{
	public Lazy(System::Func<T> function) : this
	(
		new Function::From.System<T>(function)
	)
	{
	}
	
	public Lazy(Function::Any<T> function) : base
	(
		new Property::Lazy<T>(
			new Property::Function.Result.Actual<T>(function))
	)
	{
	}
}