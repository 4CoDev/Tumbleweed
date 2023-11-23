using String = Tumbleweed.String;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using System = System;

namespace Tumbleweed.String.Function.Result;

public sealed class Actual : String::Any
{
	public Actual
	(
		Func<String::Any> function
	) : this
	(
		new Function::From.System<Any>(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<String::Any> function
	)
	{
		this.function = function;
	}

	public global::System.String AsSystem =>
		function.Result.AsSystem;
	
	private readonly Function::Any<String::Any> function;
}