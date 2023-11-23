using Function = Tumbleweed.Subroutine.Function.Unary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Function.Unary.From;

public sealed class System<Parameter, Result>
	: Function::Any<Parameter, Result>
{ 
	public System
	(
		Func<Parameter, Result> function
	) 
	{
		this.function = function;
	}


	public Result ResultWith(Parameter parameter) =>
		function.Invoke(parameter);

	private readonly Func<Parameter, Result> function;
}